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

namespace AddFood
{
    public partial class OrderManager : UserControl
    {
        public OrderManager()
        {
            InitializeComponent();
        }

        private void OrderManager_Load(object sender, EventArgs e)
        {
            sDgvMain.AutoGenerateColumns = false;
            sDgvMain.DataSource = BLL.OrderManagers.SelectOrderAll();
        }

        //订单信息
        private void tsmiFindOrderInfo_Click(object sender, EventArgs e)
        {
            if (sDgvMain.SelectedRows.Count>0)
            {
                FrmOrderInfo frmo = new FrmOrderInfo();
                string orderId = sDgvMain.SelectedRows[0].Cells["clOrderId"].Value.ToString();
                string Sum = sDgvMain.SelectedRows[0].Cells["clMoney"].Value.ToString();
                List<OrderInfos> od= OrderManagers.SelectOrderInfo(orderId);
                frmo.lbOrderId.Text = od[0].OrderId;
                frmo.lbTableId.Text = od[0].TableId.ToString();
                frmo.dgvOrderInfo.AutoGenerateColumns = false;
                frmo.dgvOrderInfo.DataSource = OrderManagers.SelectOrderInfo(orderId);
                frmo.lbxiaofei.Text = od.Count.ToString();
                frmo.lbSum.Text = Sum.Substring(0,5);
                frmo.ShowDialog();
            }
        }

        #region 导出表
        //导出表
        private void tsmiDaoChu_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 

            //写入标题      
            for (int i = 0; i < sDgvMain.ColumnCount; i++)
            { worksheet.Cells[1, i + 1] = sDgvMain.Columns[i].HeaderText; }
            //写入数值
            for (int r = 0; r < sDgvMain.Rows.Count; r++)
            {
                for (int i = 0; i < sDgvMain.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = sDgvMain.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show(fileName + "订单导出成功", "提示", MessageBoxButtons.OK);
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;     
                }
                catch (Exception ex)

                {//fileSaved = false;                      

                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁
        }
        #endregion
        private void txtTable_Click(object sender, EventArgs e)
        {
            if (txtTable.ForeColor == Color.Gray)
            {
                txtTable.Text = "";
                txtTable.ForeColor = Color.Black;
            }
        }

        private void txtOrderId_Click(object sender, EventArgs e)
        {
            if (txtOrderId.ForeColor == Color.Gray)
            {
                txtOrderId.Text = "";
                txtOrderId.ForeColor = Color.Black;
            }
        }

 

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtTable.ForeColor==Color.Gray || txtTable.Text=="")
            {
                MessageBox.Show("请输入桌号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTable.Text = "";
                txtTable.ForeColor = Color.Black;
                txtTable.Focus();
            }
            else if (txtOrderId.ForeColor == Color.Gray || txtOrderId.Text == "" )
            {
                MessageBox.Show("请输入订单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOrderId.Text = "";
                txtOrderId.ForeColor = Color.Black;
                txtTable.Focus();
            }
           
            if (txtTable.ForeColor == Color.Black && txtOrderId.ForeColor == Color.Black)
            {
                OrderInfo oi = new OrderInfo()
                {
                    TableId = Convert.ToInt32(txtTable.Text),
                    OrderId = txtOrderId.Text
                };
                if (BLL.OrderManagers.SelectOrderBycon(oi).Count > 0)
                {
                    sDgvMain.DataSource = BLL.OrderManagers.SelectOrderBycon(oi);
                    txtTable.Text = "桌号";
                    txtOrderId.Text = "订单号";
                    txtTable.ForeColor = Color.Gray;
                    txtOrderId.ForeColor = Color.Gray;
                }
                else
                {
                    sDgvMain.DataSource = BLL.OrderManagers.SelectOrderAll();
                    if (txtTable.ForeColor == Color.Black && txtOrderId.ForeColor == Color.Black)
                    {
                        txtTable.Text = "桌号";
                        txtOrderId.Text = "订单号";
                        txtTable.ForeColor = Color.Gray;
                        txtOrderId.ForeColor = Color.Gray;
                    }
                    MessageBox.Show("抱歉！没有你要查询的订单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTable.Text = "桌号";
                    txtOrderId.Text = "订单号";
                    txtTable.ForeColor = Color.Gray;
                    txtOrderId.ForeColor = Color.Gray;
                }
            }
        }

        private void btnFindTT_Click(object sender, EventArgs e)
        {
            if (sdtpDateOne.Text == "")
            {
                MessageBox.Show("请输入日期", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sdtpDateOne.Focus();
            }
            else
            {
                OrderInfo oi = new OrderInfo()
                {
                    PayTime = Convert.ToDateTime(sdtpDateOne.Text),
                };
                if (BLL.OrderManagers.SelectOrderByDateOne(oi).Count > 0)
                {
                    sDgvMain.DataSource = BLL.OrderManagers.SelectOrderByDateOne(oi);
                }
                else
                {
                    sDgvMain.DataSource = BLL.OrderManagers.SelectOrderAll();
                    MessageBox.Show("抱歉！没有你要查询的订单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            sDgvMain.DataSource = BLL.OrderManagers.SelectOrderAll();
            txtTable.Text = "桌号";
            txtOrderId.Text = "订单号";
            txtTable.ForeColor = Color.Gray;
            txtOrderId.ForeColor = Color.Gray;
        }
    }
}

