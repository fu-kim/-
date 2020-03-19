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
using FrmActivity;
using Food;
using System.Speech.Synthesis;
using Models;
using BLL;

namespace AddFood
{
    public partial class FrmMain : Skin_DevExpress
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Transmit.FrmMain = this;
            lblTime.Text = "当前时间   "+DateTime.Now.ToShortDateString()+"   "+DateTime.Now.ToShortTimeString();
            plMain.Controls.Clear();
            //btnTableManager.BaseColor = Color.SkyBlue;
            FrmTable tb = new FrmTable();
            tb.Show();
            plMain.Controls.Clear();
            plMain.Controls.Add(tb);
            //btnTableManager_Click(sender, e);

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnTableManager_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cornsilk;
            btnTableManager.BaseColor = Color.Brown;
            btnFoodManager.BaseColor = Color.Black;
            btnOrderManager.BaseColor = Color.Black;
            btnActivityManager.BaseColor = Color.Black;
            btnStaffManager.BaseColor = Color.Black;
            btnAssociatorManager.BaseColor = Color.Black;
            plMain.Controls.Clear();
            FrmTable tb = new FrmTable();
            //Transmit.FrmTableInfo.timer3.Enabled = true;
            tb.Show();
            plMain.Controls.Add(tb);

        }
        private void btnFoodManager_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cornsilk;
            btnFoodManager.BaseColor = Color.Brown;
            btnTableManager.BaseColor = Color.Black;
            btnOrderManager.BaseColor = Color.Black;
            btnActivityManager.BaseColor = Color.Black;
            btnStaffManager.BaseColor = Color.Black;
            btnAssociatorManager.BaseColor = Color.Black;
            plMain.Controls.Clear();
            //Transmit.FrmTableInfo.timer3.Enabled = false;
            FrmFood ff = new FrmFood();
            ff.Show();
            plMain.Controls.Add(ff);

        }
        private void btnOrderManaher_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cornsilk;
            btnOrderManager.BaseColor = Color.Brown;
            btnTableManager.BaseColor = Color.Black;
            btnFoodManager.BaseColor = Color.Black;
            btnActivityManager.BaseColor = Color.Black;
            btnStaffManager.BaseColor = Color.Black;
            btnAssociatorManager.BaseColor = Color.Black;
            plMain.Controls.Clear();
            //Transmit.FrmTableInfo.timer3.Enabled = false;
            OrderManager om = new OrderManager();
            om.Show();
            plMain.Controls.Add(om);

        }
        private void btnActivityManager_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cornsilk;
            btnActivityManager.BaseColor = Color.Brown;
            btnTableManager.BaseColor = Color.Black;
            btnFoodManager.BaseColor = Color.Black;
            btnOrderManager.BaseColor = Color.Black;
            btnStaffManager.BaseColor = Color.Black;
            btnAssociatorManager.BaseColor = Color.Black;
            plMain.Controls.Clear();
            //Transmit.FrmTableInfo.timer3.Enabled = false;
            FrmActivity.FrmActivity fa = new FrmActivity.FrmActivity();
            fa.Show();
            plMain.Controls.Add(fa);
        }
        private void btnStaffManager_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Cornsilk;
            btnStaffManager.BaseColor = Color.Brown;
            btnTableManager.BaseColor = Color.Black;
            btnFoodManager.BaseColor = Color.Black;
            btnOrderManager.BaseColor = Color.Black;
            btnActivityManager.BaseColor = Color.Black;
            btnAssociatorManager.BaseColor = Color.Black;
            StaffInfoManager user = new StaffInfoManager();
            //Transmit.FrmTableInfo.timer3.Enabled = false;
            user.Show();
            plMain.Controls.Clear();
            plMain.Controls.Add(user);
        }
        private void btnAssociatorManager_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            btnStaffManager.BaseColor = Color.Black;
            btnTableManager.BaseColor = Color.Black;
            btnFoodManager.BaseColor = Color.Black;
            btnOrderManager.BaseColor = Color.Black;
            btnActivityManager.BaseColor = Color.Black;
            btnAssociatorManager.BaseColor = Color.Gold;
            FrmAssociator asso = new FrmAssociator();
            //Transmit.FrmTableInfo.timer3.Enabled = false;
            asso.Show();
            plMain.Controls.Clear();
            plMain.Controls.Add(asso);
        }
        int istype = 0;
        SpeechSynthesizer voice = null;
        public void Player(string str)
        {
            voice = new SpeechSynthesizer();   //创建语音实例
            voice.SelectVoiceByHints(VoiceGender.Male);//指示语音性别
            voice.Rate = 1; //设置语速,[-10,10]
            voice.Volume = 100; //设置音量,[0,100]
            voice.SpeakAsync(str);  //播放指定的字符串,这是异步朗读
            //oice.SpeakAsyncCancelAll();  //取消朗读
            //oice.Speak("一五三班提醒您，代码千万条，开源第一条，代码不规范，他人两行泪");  //同步朗读
            //oice.Dispose();  //释放s所有语音资源
            //oice.Pause();  //暂停朗读
            //oice.SpeakAsyncCancelAll();//取消所有排队语音
            //oice.Resume(); //继续朗读
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (istype == 1)
            {
                Player("2号桌需要服务");
            }
            else if (istype == 2)
            {
                Player("2号桌客户催单");
            }
            else if (istype == 3)
            {
                Player("2号桌选择现金付款");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            List<Table> tb = Transmit.FrmTable.IsService;
            List<Table> ist = TableManager.SelectTableIsServiceType("2");
            for (int i = 0; i < tb.Count; i++)
            {
                if ("2" == tb[i].TableId.ToString())
                {
                    if (ist[i].IsService != 0)
                    {
                        istype = ist[i].IsService;
                        timer1.Enabled = true;

                    }
                    //MessageBox.Show(tb[i].TableId.ToString());

                }
            }
        }
    }
}
