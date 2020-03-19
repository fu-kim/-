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
using System.Speech.Synthesis;

namespace AddFood
{
    public partial class FrmTableInfo : UserControl
    {
        public FrmTableInfo()
        {
            InitializeComponent();
        }

        #region 鼠标移动事件
        private void plBgColor_MouseMove(object sender, MouseEventArgs e)
        {
            plBgColor.BackColor = Color.Orange;       
        }

        private void plBgColor_MouseLeave(object sender, EventArgs e)
        {
            plBgColor.BackColor = Color.Transparent;
        }
        #endregion
        private void pbxTableType_Click(object sender, EventArgs e)
        {
            Transmit.FrmTable.lbTableId.Text = lbTableId.Text;
            string TableType = TableManager.SelectTypebyId(lbTableId.Text).ToString() ;
            Transmit.FrmTable.lbTableType.Text = TableType;

            if (TableType=="占用中")
            {

               List<Order> od = TableManager.SelectOrderInfo(lbTableId.Text);
                Transmit.FrmTable.lbOrderId.Text = od[0].OrderId;
                Transmit.FrmTable.lbPrice.Text = od[0].Price.ToString().Substring(0,5);
                Transmit.FrmTable.lbPayTime.Text = od[0].PayTime.ToString();
                Transmit.FrmTable.lbIsPay.Text = "是";
            }
            else if (TableType=="点菜中")
            {
                List<Order> od = TableManager.SelectOrderInfo(lbTableId.Text);
                Transmit.FrmTable.lbOrderId.Text = od[0].OrderId;
                Transmit.FrmTable.lbIsPay.Text = "否";
                Transmit.FrmTable.lbPrice.Text = "";
                Transmit.FrmTable.lbPayTime.Text = "";
            }
            else
            {
                Transmit.FrmTable.lbOrderId.Text ="";
                Transmit.FrmTable.lbPrice.Text = "";
                Transmit.FrmTable.lbPayTime.Text = "";
                Transmit.FrmTable.lbIsPay.Text = "";
            }
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            Transmit.FrmTable.FrmTable_Load(sender, e);
        }
        public int istype = 0;
    
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Table> tba = TableManager.SelectTableAll();
            for (int i = 0; i < tba.Count; i++)
            {
                if (lbTableId.Text == tba[i].TableId.ToString())
                {
                    int type = tba[i].TableTypeId;
                    switch (type)
                    {
                        case 1: pbxTableType.BackColor = Color.MediumSpringGreen; break;
                        case 2: pbxTableType.BackColor = Color.Goldenrod; break;
                        case 3: pbxTableType.BackColor = Color.Tomato; break;
                        case 4: pbxTableType.BackColor = Color.Silver; break;
                        case 5: pbxTableType.BackColor = Color.DeepSkyBlue; break;
                    }
                }
            }
            List<Table> tb = Transmit.FrmTable.IsService;
            List<Table> ist = TableManager.SelectTableIsServiceType(lbTableId.Text);
            for (int i = 0; i < tb.Count; i++)
            {
                if (lbTableId.Text== tb[i].TableId.ToString())
                {
                    if (ist[i].IsService!=0)
                    {
                        istype = ist[i].IsService;
                        timer2.Enabled = true;
                    }
                    //MessageBox.Show(tb[i].TableId.ToString());

                }
            }
        }
        string[] color1 = new string[] { "yellow", "while", };
        string[] color2 = new string[] { "SkyBlue", "while", };
        string[] color3 = new string[] { "red", "while", };
        int col = 0;
        private void timer2_Tick(object sender, EventArgs e)
        { 
            if (istype==1)
            {
                if (col == color1.Length - 1)
                {
                    col = 0;
                }
                else
                {
                    col++;
                }
                plBgColor.BackColor = Color.FromName(color1[col]);
            }
            else if (istype == 2)
            {
                if (col == color2.Length - 1)
                {
                    col = 0;
                }
                else
                {
                    col++;
                }
                plBgColor.BackColor = Color.FromName(color2[col]);
            }
            else if (istype == 3)
            {
                if (col == color3.Length - 1)
                {
                    col = 0;
                }
                else
                {
                    col++;
                }
                plBgColor.BackColor = Color.FromName(color3[col]);
            }
        }

        private void tsmiYesService_Click(object sender, EventArgs e)
        {
            TableManager.UpdateIsService(lbTableId.Text,0);
            timer2.Enabled = false;
            Transmit.FrmMain.timer1.Enabled = false;
            plBgColor.BackColor = Color.Transparent;
        }

        private void tsmiKongZhuo_Click(object sender, EventArgs e)
        {
            TableManager.UpdateTypebyTableId(1,lbTableId.Text);
            Transmit.FrmTable.FrmTable_Load(sender, e);
        }

        private void tsmiDaSao_Click(object sender, EventArgs e)
        {
            TableManager.UpdateTypebyTableId(2, lbTableId.Text);
            Transmit.FrmTable.FrmTable_Load(sender, e);
        }

        private void tsmiWeiXiu_Click(object sender, EventArgs e)
        {
            TableManager.UpdateTypebyTableId(4, lbTableId.Text);
            Transmit.FrmTable.FrmTable_Load(sender, e);
        }

        private void tsmiZanYong_Click(object sender, EventArgs e)
        {
            TableManager.UpdateTypebyTableId(3, lbTableId.Text);
            Transmit.FrmTable.FrmTable_Load(sender, e);
        }

        private void tsmiDianCai_Click(object sender, EventArgs e)
        {
            TableManager.UpdateTypebyTableId(5, lbTableId.Text);
            Transmit.FrmTable.FrmTable_Load(sender, e);
        }
        
        private void plBgColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTableInfo_Load(object sender, EventArgs e)
        {
            Transmit.FrmTableInfo = this;
        }

        private void tsmiPay_Click(object sender, EventArgs e)
        {
            TableManager.UpdateTypebyTableId(3, lbTableId.Text);
            TableManager.UpdateIsService(lbTableId.Text, 0);
            timer2.Enabled = false;
            Transmit.FrmMain.timer1.Enabled = false;
            plBgColor.BackColor = Color.Transparent;
            pbxTableType.BackColor = Color.Tomato;
        }
    }
}
