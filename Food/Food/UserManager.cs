using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;
using Food;

namespace AddFood
{
    public partial class UserManager : UserControl
    {
        FrmStaffInfo frm = null;//员工信息列表窗口对象：父窗口
        public string StaffId { get; set; }//当前员工编号

        List<string> images = new List<string>();
        int index = 0;
        Dictionary<string, StaffInfo> st = new Dictionary<string, StaffInfo>();
        public UserManager(FrmStaffInfo frm)
        {
            this.frm = frm;
            InitializeComponent();
        }
        
        #region 窗体加载
        private void UserManager_Load(object sender, EventArgs e)
        {
            lblStaffId.Text = frm.dgvMain.SelectedRows[0].Cells[0].Value.ToString();
            StaffInfo si = StaffManager.SelectStaffInfoByStaffId(lblStaffId.Text);
            if (si!= null)
            {
                lblName.Text = si.StaffName + "的个人信息";
                txtName.Text = si.StaffName;
                cboSex.Text = si.StaffSex;
                cboAge.Text = Convert.ToString(si.StaffAge);
                dtpBirthday.Text = Convert.ToString(si.StaffBirthday);
                txtDress.Text = si.StaffAddress;
                txtTel.Text = si.StaffTel;
                txtCard.Text = si.StaffCardId;
                txtEName.Text = si.EContact;
                txtETel.Text = si.EContactTel;
                cboType.Text = si.TypeId;
            }
        }
        #endregion

        #region 删除事件方法
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lblStaffId.Text;
            try
            {
                DialogResult ret = MessageBox.Show("你确定要删除该员工吗?", "提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    int n = StaffManager.DeleteStaffInfo(id);
                    if (n > 0)
                    {
                        MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        txtName.Text = "";
                        cboAge.Text = "";
                        cboSex.Text = "";
                        dtpBirthday.Text = "";
                        txtDress.Text = "";
                        txtTel.Text = "";
                        txtCard.Text = "";
                        txtEName.Text = "";
                        txtETel.Text = "";
                        cboType.Text = "";
                        lblStaffId.Text = "";
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region 添加事件方法
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                StaffInfo sf = new StaffInfo()
                {
                    StaffName = txtName.Text,
                    StaffSex = cboSex.Text,
                    StaffAge = Convert.ToInt32(cboAge.Text),
                    StaffBirthday = Convert.ToDateTime(dtpBirthday.Text),
                    StaffAddress = txtDress.Text == "" ? "无" : txtDress.Text,
                    StaffTel = txtTel.Text,
                    StaffCardId = txtCard.Text,
                    EContact = txtEName.Text == "" ? "无" : txtEName.Text,
                    EContactTel = txtETel.Text == "" ? "无" : txtETel.Text,
                    TypeId = cboType.Text,
                };
                StaffInfo nt = StaffManager.SelectStaffByCID(txtCard.Text);
                if (nt != null)
                {
                    MessageBox.Show("身份证相同", "提示");
                    return;
                }
                int n = StaffManager.InsertStaff(sf);
                if (n > 0)
                {
                    MessageBox.Show("添加成功!", "提示");
                }
                else
                {
                    MessageBox.Show("该员工已存在,添加失败", "提示");
                }
            }
        }
        #endregion

        #region 重置
        public void btnReset_Click_1(object sender, EventArgs e)
        {
            lblName.Text = "个人资料信息";
            txtName.Text = "";
            cboAge.Text = "";
            cboSex.Text = "";
            dtpBirthday.Text = "";
            txtDress.Text = "";
            txtTel.Text = "";
            txtCard.Text = "";
            txtEName.Text = "";
            txtETel.Text = "";
            cboType.Text = "";
            lblStaffId.Text = "";
        }
        #endregion

        #region 修改
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                StaffInfo sf = new StaffInfo()
                {
                    StaffId = Convert.ToInt32(lblStaffId.Text),
                    StaffName = txtName.Text,
                    StaffSex = cboSex.Text,
                    StaffAge = Convert.ToInt32(cboAge.Text),
                    StaffBirthday = Convert.ToDateTime(dtpBirthday.Text),
                    StaffAddress = txtDress.Text == "" ? "无" : txtDress.Text,
                    StaffTel = txtTel.Text,
                    StaffCardId = txtCard.Text,
                    EContact = txtEName.Text == "" ? "无" : txtEName.Text,
                    EContactTel = txtETel.Text == "" ? "无" : txtETel.Text,
                    TypeId = cboType.Text,
                };
                int n = StaffManager.UpdateStaff(sf);
                if (n > 0)
                {
                    MessageBox.Show("修改成功！", "提示");
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                }
            }
        }
        #endregion

        #region 输入完整性
        private bool CheckInfo()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("姓名不能为空", "提示");
                txtName.Focus();
                return false;
            }
            if (cboSex.Text != "")
            {
                if (cboSex.Text != "男" && cboSex.Text != "女")
                {
                    MessageBox.Show("性别输入有误!", "提示");
                    cboSex.Focus();
                    return false;
                }
            }
            if (cboSex.Text == "")
            {
                MessageBox.Show("性别不能为空!", "提示");
                cboSex.Focus();
                return false;
            }
            if (cboAge.Text == "")
            {
                MessageBox.Show("年龄不能为空!", "提示");
                cboAge.Focus();
                return false;
            }
            if (Convert.ToInt32(cboAge.Text) > 55 && Convert.ToInt32(cboAge.Text) < 18)
            {
                MessageBox.Show("年龄输入有误!", "提示");
                cboAge.Focus();
                return false;
            }
            if (cboType.Text == "")
            {
                MessageBox.Show("职位不能为空!", "提示");
                cboType.Focus();
                return false;
            }
            if (dtpBirthday.Text != "")
            {
                DateTime time1 = Convert.ToDateTime(dtpBirthday.Text);
                DateTime time2 = Convert.ToDateTime(DateTime.Now);
                if (time1 > time2)
                {
                    MessageBox.Show("出生日期不能大于当前日期!", "提示");
                    return false;
                }
            }
            if (dtpBirthday.Text == "")
            {
                MessageBox.Show("出生日期不能为空!", "提示");
                dtpBirthday.Focus();
                return false;
            }
            if (txtTel.Text != "")
            {
                if (txtTel.Text.Length !=11)
                {
                    MessageBox.Show("联系方式不足11位数!", "提示");
                    txtTel.Focus();
                    return false;
                }
            }
            if (txtTel.Text == "")
            {
                MessageBox.Show("联系方式不能为空!", "提示");
                txtTel.Focus();
                return false;
            }
            if (txtCard.Text != "")
            {
                if (txtCard.Text.Length != 18)
                {
                    MessageBox.Show("身份证位数不足18位!", "提示");
                    txtCard.Focus();
                    return false;
                }
            }
            if (txtCard.Text == "")
            {
                MessageBox.Show("身份证不能为空!", "提示");
                txtCard.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region 选择头像
        private void picPot_Click(object sender, EventArgs e)
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

        private void ShowLabelInfo()
        {
            if (images.Count > 0)
            {
                Image img = Image.FromFile(images[index]);
                if (img.Height > picPot.Height || img.Width > picPot.Width)
                {
                    picPot.SizeMode = PictureBoxSizeMode.Zoom;
                    picPot.Image = img;
                }
                else
                {
                    picPot.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
        }
        #endregion

        private void picReturn_Click(object sender, EventArgs e)
        {
            Transmit.StaffInfoManager.plStaffInfo.Controls.Clear();
            FrmStaffInfo StaffInfo = new FrmStaffInfo();
            StaffInfo.Show();
            Transmit.StaffInfoManager.plStaffInfo.Controls.Add(StaffInfo);
        }
    }
}
