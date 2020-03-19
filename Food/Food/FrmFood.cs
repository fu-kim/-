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
using System.IO;

namespace AddFood
{
    public partial class FrmFood : UserControl
    {
        public FrmFood()
        {
            InitializeComponent();
        }

        private void FrmFood_Load(object sender, EventArgs e)
        {
            Transmit.FrmFood = this;
            btnAllFood.BaseColor = Color.SkyBlue;
            dgvFoodInfo.DataSource = FoodManager.SelectFoodAll();
            dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectFood();
        }
        #region 选择DGV食物显示信息      
        public void SelectFood()
        {
            txtFoodName.Text = dgvFoodInfo.SelectedRows[0].Cells["clFoodName"].Value.ToString();
            txtFoodId.Text = dgvFoodInfo.SelectedRows[0].Cells["clFoodId"].Value.ToString();
            txtPrice.Text = dgvFoodInfo.SelectedRows[0].Cells["clPrice"].Value.ToString();
            txtTime.Text = dgvFoodInfo.SelectedRows[0].Cells["clTime"].Value.ToString();
            cboFoodType.Text = dgvFoodInfo.SelectedRows[0].Cells["clFoodType"].Value.ToString();
            pictureBox1.Image = Image.FromFile
               (Application.StartupPath + @"\Images\食物\" + txtFoodName.Text + ".jpg");
        }
        #endregion

        private void dgvFoodInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectFood();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd fa = new FrmAdd();
            fa.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("你确定要删除当前信息吗？", "删除警告",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                int n = FoodManager.DeleteFood(txtFoodId.Text);
                string txt = txtFoodName.Text;
                if (n > 0)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                    btnAllFood.BaseColor = Color.SkyBlue;
                    dgvFoodInfo.DataSource = FoodManager.SelectFoodAll();
                    dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    SelectFood();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvFoodInfo.DataSource = FoodManager.SelectFoodAll();
            dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectFood();
        }

        private void btnHotFood_Click(object sender, EventArgs e)
        {
            #region 按钮换色
            btnHotFood.BaseColor = Color.SkyBlue;
            btnAllFood.BaseColor = Color.Silver;
            btnColdFood.BaseColor = Color.Silver;
            btnSoups.BaseColor = Color.Silver;
            btnWine.BaseColor = Color.Silver;
            btnOther.BaseColor = Color.Silver;
            #endregion
            dgvFoodInfo.DataSource = FoodManager.SelectHotFoodAll();
            dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectFood();
        }

        private void btnColdFood_Click(object sender, EventArgs e)
        {
            #region 按钮换色
            btnHotFood.BaseColor = Color.Silver;
            btnAllFood.BaseColor = Color.Silver;
            btnColdFood.BaseColor = Color.SkyBlue;
            btnSoups.BaseColor = Color.Silver;
            btnWine.BaseColor = Color.Silver;
            btnOther.BaseColor = Color.Silver;
            #endregion
            dgvFoodInfo.DataSource = FoodManager.SelectColdFoodAll();
            dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectFood();
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            #region 按钮换色
            btnHotFood.BaseColor = Color.Silver;
            btnAllFood.BaseColor = Color.Silver;
            btnColdFood.BaseColor = Color.Silver;
            btnSoups.BaseColor = Color.SkyBlue;
            btnWine.BaseColor = Color.Silver;
            btnOther.BaseColor = Color.Silver;
            #endregion
            dgvFoodInfo.DataSource = FoodManager.SelectSoupFoodAll();
            dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectFood();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            #region 按钮换色
            btnHotFood.BaseColor = Color.Silver;
            btnAllFood.BaseColor = Color.Silver;
            btnColdFood.BaseColor = Color.Silver;
            btnSoups.BaseColor = Color.Silver;
            btnWine.BaseColor = Color.SkyBlue;
            btnOther.BaseColor = Color.Silver;
            #endregion
            dgvFoodInfo.DataSource = FoodManager.SelectWineFoodAll();
            dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectFood();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            #region 按钮换色
            btnHotFood.BaseColor = Color.Silver;
            btnAllFood.BaseColor = Color.Silver;
            btnColdFood.BaseColor = Color.Silver;
            btnSoups.BaseColor = Color.Silver;
            btnWine.BaseColor = Color.Silver;
            btnOther.BaseColor = Color.SkyBlue;
            #endregion
            dgvFoodInfo.DataSource = FoodManager.SelectElseFoodAll();
            dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectFood();
        }

        private void btnAllFood_Click(object sender, EventArgs e)
        {
            #region 按钮换色
            btnHotFood.BaseColor = Color.Silver;
            btnAllFood.BaseColor = Color.SkyBlue;
            btnColdFood.BaseColor = Color.Silver;
            btnSoups.BaseColor = Color.Silver;
            btnWine.BaseColor = Color.Silver;
            btnOther.BaseColor = Color.Silver;
            #endregion
            dgvFoodInfo.DataSource = FoodManager.SelectFoodAll();
            dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectFood();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Foods F = new Foods()
            {
                FoodName = txtFoodName.Text,
                FoodPrice = Convert.ToDecimal(txtPrice.Text),
                FoodType =( cboFoodType.SelectedIndex+1).ToString(),
                FoodTime = TimeSpan.Parse(txtTime.Text),
                FoodId = Convert.ToInt32(txtFoodId.Text)
            };
            int n = FoodManager.UpdateFood(F);
            if (n > 0)
            {
                MessageBox.Show("修改成功");
                dgvFoodInfo.DataSource = FoodManager.SelectFoodAll();
                dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                SelectFood();
            }
            else
            {
                MessageBox.Show("修改失败");

            }
        }
    }
}
