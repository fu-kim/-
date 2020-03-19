using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaMiFood
{
    public partial class FrmPaying : Form
    {
        public FrmPaying()
        {
            InitializeComponent();
        }
        string OrderId ;
        static decimal SumPrice;
        DateTime PayTime;
        int TableId = Convert.ToInt32(Transmit.FrmMenu.lbTableId.Text);
        decimal VipSumPrice;
        string Remarks = "";
        bool IsPay = true;
        private void pbxXianJin_Click(object sender, EventArgs e)
        {
            OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            SumPrice = Convert.ToDecimal(lbSum.Text);
            PayTime = Convert.ToDateTime(DateTime.Now.ToString());
            VipSumPrice = Convert.ToDecimal(lbMemberSum.Text);
            if (Transmit.FrmFoodMain.Tipskc("确定结账吗？"))
            {
                Transmit.FrmFoodMain.IsPays = true;
                TableManager.UpdateIsService(TableId.ToString(), 3);
                Transmit.FrmFoodMain.Tipsk("服务员正赶来收钱");
                timer2.Enabled = true;
            }
        }

        private void pbxWeiXin_Click(object sender, EventArgs e)
        {
            pbxErWeiMa.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\微信二维码.png");
        }

        private void pbxZhiFuBao_Click(object sender, EventArgs e)
        {
            pbxErWeiMa.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\支付宝二维码.png");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGundong.Left -= 5;
            if (lbGundong.Right < 0)
            {
                lbGundong.Left = plGun.Width;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int TableTypeId = (int)TableManager.SelectTableTypeId(TableId.ToString());
            if (TableTypeId==3)
            {
                if (Transmit.FrmFoodMain.llbVIP.Text != "未登录")
                {
                    int n = OrderManager.InsertPayInfo(TableId, OrderId, VipSumPrice, PayTime, Remarks, IsPay);
                    OrderManager.InsertPay(OrderId, PayTime, IsPay);
                    if (n > 0)
                    {
                        Transmit.FrmPay.FrmPay_Load(sender, e);
                        Transmit.FrmPay.lbSumRmb.Text = "0";
                        List<Schedule> sd = ScheduleManager.selectScheduleValues();
                        ScheduleManager.DeleteSchedule();
                        TableManager.UpdateTableNowInfo(Transmit.FrmMenu.lbTableId.Text, OrderId, PayTime, SumPrice, Remarks, IsPay);
                        for (int i = 0; i < sd.Count; i++)
                        {
                            DateTime dt = Convert.ToDateTime(sd[i].FTime);
                            int mm = dt.Minute;
                            DateTime NowDt = DateTime.Now;
                            DateTime FTime = NowDt.AddMinutes(mm * sd[i].FNumber);
                            string finish = FTime.ToString();
                            ScheduleManager.InsertSchedule(TableId, sd[i].OrderId, sd[i].FName, finish, sd[i].FNumber, sd[i].IsPay);
                        }
                    }
                    timer2.Enabled = false;
                    this.Close();
                }
                else
                {
                    int n = OrderManager.InsertPayInfo(TableId, OrderId, SumPrice, PayTime, Remarks, IsPay);
                    OrderManager.InsertPay(OrderId, PayTime, IsPay);
                    if (n > 0)
                    {
                        Transmit.FrmPay.FrmPay_Load(sender, e);
                        Transmit.FrmPay.lbSumRmb.Text = "0";
                        List<Schedule> sd = ScheduleManager.selectScheduleValues();
                        ScheduleManager.DeleteSchedule();
                        TableManager.UpdateTypebyTableId(3, Transmit.FrmMenu.lbTableId.Text);
                        TableManager.UpdateTableNowInfo(Transmit.FrmMenu.lbTableId.Text, OrderId, PayTime, SumPrice, Remarks, IsPay);
                        for (int i = 0; i < sd.Count; i++)
                        {
                            DateTime dt = Convert.ToDateTime(sd[i].FTime);
                            int mm = dt.Minute;
                            DateTime NowDt = DateTime.Now;
                            DateTime FTime = NowDt.AddMinutes(mm * sd[i].FNumber);
                            string finish = FTime.ToString();
                            ScheduleManager.InsertSchedule(TableId, sd[i].OrderId, sd[i].FName, finish, sd[i].FNumber, sd[i].IsPay);
                        }
                    }
                    timer2.Enabled = false;
                    this.Close();
                }

            }

        }

        private void plchufa_Click(object sender, EventArgs e)
        {
            OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            SumPrice = Convert.ToDecimal(lbSum.Text);
            PayTime = Convert.ToDateTime(DateTime.Now.ToString());
            VipSumPrice = Convert.ToDecimal(lbMemberSum.Text);
            Transmit.FrmFoodMain.IsPays = true;
            TableManager.UpdateTypebyTableId(3, TableId.ToString());
            timer2.Enabled = true;
        }

        private void FrmPaying_Load(object sender, EventArgs e)
        {

        }
    }
}
