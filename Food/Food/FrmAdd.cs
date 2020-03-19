using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using Models;
using BLL;
using System.IO;
using System.Reflection;

namespace AddFood
{
    public partial class FrmAdd : CCSkinMain
    {
        public FrmAdd()
        {
            InitializeComponent();
        }
        string file = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //校验信息完整性
            if (CheckInput())
            {
                Foods F = new Foods()
                {
                    FoodName = txtFoodName.Text,
                    FoodPrice = Convert.ToDecimal(cboFoodPrice.Text),
                    FoodType = (cboFoodType.SelectedIndex+1).ToString(),
                    FoodTime = TimeSpan.Parse("00:"+nudtxtFoodTime.Text+":00"),
                };
                int n = FoodManager.InsertFood(F);
                string pLocalFilePath = file;//要复制的文件路径

                string path = Application.StartupPath;
                int index = path.IndexOf("KaMiFoodSystem");
                path = path.Substring(0, index)+ "KaMiFoodSystem";

                string pSaveFilePath = Application.StartupPath + @"\Images\食物\"+ txtFoodName.Text+".jpg";//指定存储的路径
                string pSaveFilePath2 = path + @"\KaMiFood\KaMiFood\bin\Debug\Images\食物\" + txtFoodName.Text + ".jpg";//指定存储的路径
                File.Copy(pLocalFilePath, pSaveFilePath, true);
                File.Copy(pLocalFilePath, pSaveFilePath2, true);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                    Transmit.FrmFood.dgvFoodInfo.DataSource = FoodManager.SelectFoodAll();
                    Transmit.FrmFood.dgvFoodInfo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Transmit.FrmFood.SelectFood();
                    this.Close();
                }
            }
        }
        #region 校验输入的完整性
        private bool CheckInput()
        {
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("请输入菜品名称！", "输入提示");
                txtFoodName.Focus();
                return false;
            }
            else if (cboFoodPrice.Text == "")
            {
                MessageBox.Show("请输入菜品价格！", "输入提示");
                cboFoodPrice.Focus();
                return false;
            }
            else if (nudtxtFoodTime.Text == "")
            {
                MessageBox.Show("请输入菜品时间！", "输入提示");
                nudtxtFoodTime.Focus();
                return false;
            }
            else if(file=="")
            {
                MessageBox.Show("请选择菜品图片！", "输入提示");
                return false;
            }
            return true;
        }
        #endregion

        private void pbxFoodImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
                pbxFoodImage.Image = Image.FromFile(file); 
            }
            

        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            cboFoodPrice.SelectedIndex = 0;
            cboFoodType.SelectedIndex = 6;
        }
    }
}
