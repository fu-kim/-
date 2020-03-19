using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;
using DAL;

namespace FrmActivity
{
    public partial class FrmActivity : UserControl
    {


        private Color SetColor = Color.AliceBlue;

        int a, b = 0;

        public FrmActivity()
        {
            InitializeComponent();
        }
        private void SelectDGV()
        {
            txtActivityTitle.Text = dgvTextAInfo.SelectedRows[0].Cells["clAName"].Value.ToString();
            cboActicityType.Text = tbA.Text;
            dtpStartTime.Text = dgvTextAInfo.SelectedRows[0].Cells["clATime"].Value.ToString();
            dtpOverTime.Text = dgvTextAInfo.SelectedRows[0].Cells["clTimeEnd"].Value.ToString();
        }
        private void SelectDGV2()
        {
            txtActivityTitle1.Text = dgvAInfo.SelectedRows[0].Cells["AName"].Value.ToString();
            cboActivityType1.Text = tbS.Text;
            dtpTime1.Text = dgvAInfo.SelectedRows[0].Cells["ATime"].Value.ToString();
            dtpTime2.Text = dgvAInfo.SelectedRows[0].Cells["ATimeEnd"].Value.ToString();
        }
        private void FrmActivity_Load(object sender, EventArgs e)
        {          
            dgvTextAInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTextAInfo.DataSource = ActivityManager.SelectFestivalActivityAll();
            dgvAInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAInfo.DataSource = ActivityManager.SelectActivityAll(); SelectDGV();
        }
        #region 活动图片    
        List<string> images = new List<string>();
        int index = 0;
        private void ShowLabelInfo()
        {
            if (images.Count > 0)
            {
                Image img = Image.FromFile(images[index]);
                if (img.Height > picActivity.Height || img.Width > picActivity.Width)
                {
                    picActivity.SizeMode = PictureBoxSizeMode.Zoom;
                    picActivity.Image = img;
                }
                else
                {
                    picActivity.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
        }
        #endregion
        public static int InsertTextActivity(Actiivity A)
        {
            int n = 0;
            string sql = "Insert TextActivityInfo(AName,ATime,ATimeEnd) ";
            sql += "Values ('{0}','{1}','{2}')";
            sql = string.Format(sql, A.AName, A.ATime, A.ATimeEnd);
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        public static int InsertActivity(Actiivity A)
        {
            int n = 0;
            string sql = "Insert ActivityInfo(AName,ATime,ATimeEnd) ";
            sql += "Values ('{0}','{1}','{2}')";
            sql = string.Format(sql, A.AName, A.ATime, A.ATimeEnd);
            n = DBHelper.ExecuteNonQuery(sql);
            return n;
        }
        public void CheckInfo()
        {
            if (txtActivityTitle.Text == "")
            {
                MessageBox.Show("请输入名称");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {          
            if (TabC.SelectedTab==tbA)
            {
                txtActivityTitle.Text = "";
                txtActivityTitle.Enabled = true;
                txtUpdate.Visible = false;
                lbl.Visible = false;
                btnSave.Visible = true;            
            }
            else if (TabC.SelectedTab==tbS)
            {
                txtActivityTitle1.Text = "";
                txtActivityTitle1.Enabled = true;
                txtUpdate1.Visible = false;
                lbl1.Visible = false;
                btnSave2.Visible = true;  
            }
           else
            {
                MessageBox.Show("添加失败");
            }
        }
        private void dtpOverTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void picActivity_Click_1(object sender, EventArgs e)
        {
            //弹出文本选择对话框
            DialogResult ret = ofdDialog.ShowDialog();
            if (ret == DialogResult.Cancel)
                return;
            //获取用户所选择的文件集合
            string[] files = ofdDialog.FileNames;
            if (files.Length > 0)
            {
                images.Clear();
            }
            for (int i = 0; i < files.Length; i++)
            {
                images.Add(files[i]);
            }
            if (images.Count > 0)
            {
                ShowLabelInfo();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (TabC.SelectedTab == tbA)
            {
                DialogResult ret = MessageBox.Show("你确定要删除当前信息吗？", "删除警告",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    int n = ActivityManager.DeleteActivityByAName(txtActivityTitle.Text);
                    if (n > 0)
                    {
                        dgvTextAInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvTextAInfo.DataSource = ActivityManager.SelectFestivalActivityAll();
                        MessageBox.Show("删除成功！", "删除提示");
                    }
                }
            }
            else if (TabC.SelectedTab==tbS)
            {
                DialogResult ret = MessageBox.Show("你确定要删除当前信息吗？", "删除警告",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    int n = ActivityManager.DeleteTextActivityByAName(txtActivityTitle.Text);
                    if (n > 0)
                    {
                        dgvAInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvAInfo.DataSource = ActivityManager.SelectActivityAll(); SelectDGV();
                        MessageBox.Show("删除成功！", "删除提示");
                    }
                }
            }
            else{
                MessageBox.Show("删除失败！", "删除提示");
            }
        }
        private void dgvTextAInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtActivityTitle.Enabled = false;
            SelectDGV();
            if (DateTime.Now>dtpOverTime.Value)
            {
                picStatus.BackColor = Color.LightGreen;
                lblStatus.BackColor = Color.LightGreen;
                lblStatus.Text = "已经结束";
            }
            else if (DateTime.Now<dtpOverTime.Value&&DateTime.Now>dtpStartTime.Value)
            {
                picStatus.BackColor = Color.Bisque;
                lblStatus.BackColor = Color.Bisque;
                lblStatus.Text = "正在进行";
            }
            else if (DateTime.Now<dtpStartTime.Value)
            {
                picStatus.BackColor = Color.LightBlue;
                lblStatus.BackColor = Color.LightBlue;
                lblStatus.Text = "准备开始";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (TabC.SelectedTab == tbA)
            {
                lbl.Visible = true;
                txtUpdate.Visible = true;
                btnSave.Visible = true;
            }
            if (TabC.SelectedTab == tbS)
            {
                lbl1.Visible = true;
                txtUpdate1.Visible = true;
                btnSave2.Visible = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUpdate.Visible==false)
            {
                Actiivity F = new Actiivity()
                {
                    AName = txtActivityTitle.Text,
                    ATime = dtpStartTime.Value,
                    ATimeEnd = dtpOverTime.Value,
                };
                int n = InsertTextActivity(F);
                if (n > 0)
                {
                    dgvTextAInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTextAInfo.DataSource = ActivityManager.SelectFestivalActivityAll();
                    
                    MessageBox.Show("添加成功");
                    lbl.Visible = false;
                    txtUpdate.Visible = false;
                    btnSave.Visible = false;
                }
            }
            if (txtUpdate.Visible==true)
            {
                string name = txtUpdate.Text;
                string name2 = txtActivityTitle.Text;
                DateTime time = dtpStartTime.Value;
                DateTime time2 = dtpOverTime.Value;
                int n = ActivityManager.UpdateActivity(name,time,time2,name2);
                if (n>0)
                {
                    dgvTextAInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTextAInfo.DataSource = ActivityManager.SelectFestivalActivityAll();
                    MessageBox.Show("修改成功！");
                    lbl.Visible = false;
                    txtUpdate.Visible = false;
                    btnSave.Visible = false;
                }                
            }
                     
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (txtUpdate1.Visible == false)
            {
                Actiivity F = new Actiivity()
                {
                    AName = txtActivityTitle1.Text,
                    ATime = dtpStartTime.Value,
                    ATimeEnd = dtpOverTime.Value,
                };
                int n = InsertActivity(F);
                if (n > 0)
                {
                    dgvAInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvAInfo.DataSource = ActivityManager.SelectActivityAll(); SelectDGV();
                    MessageBox.Show("添加成功");
                    lbl1.Visible = false;
                    txtUpdate1.Visible = false;
                    btnSave2.Visible = false;
                }
            }
            if (txtUpdate1.Visible == true)
            {
                string name = txtUpdate1.Text;
                string name2 = txtActivityTitle1.Text;
                DateTime time = dtpStartTime.Value;
                DateTime time2 = dtpOverTime.Value;
                int n = ActivityManager.UpdateTextActivity(name, time, time2, name2);
                if (n>0)
                {
                    dgvAInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvAInfo.DataSource = ActivityManager.SelectActivityAll(); SelectDGV();
                    lbl1.Visible = false;
                    txtUpdate1.Visible = false;
                    btnSave2.Visible = false;
                    MessageBox.Show("修改成功！");
                }           
            }
            
        }

        private void dgvAInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDGV2();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            SelectDGV();           
        }
    }

}

       
