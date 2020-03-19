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
    public partial class FrmVIPLogin : Form
    {
        public FrmVIPLogin()
        {
            InitializeComponent();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InsertTxt(string str)
        {
            if (txtVipTel.Focused)
            {
                txtVipTel.Text += str;
            }
            if (txtVipPwd.Focused)
            {
                txtVipPwd.Text += str;
            }
        }
        private void lb1_Click(object sender, EventArgs e)
        {
            InsertTxt("1");
        }

        private void lb2_Click(object sender, EventArgs e)
        {
            InsertTxt("2");
        }

        private void lb3_Click(object sender, EventArgs e)
        {
            InsertTxt("3");
        }

        private void lb0_Click(object sender, EventArgs e)
        {
            InsertTxt("0");
        }

        private void lb6_Click(object sender, EventArgs e)
        {
            InsertTxt("6");
        }

        private void lb9_Click(object sender, EventArgs e)
        {
            InsertTxt("9");
        }

        private void lb8_Click(object sender, EventArgs e)
        {
            InsertTxt("8");
        }

        private void lb5_Click(object sender, EventArgs e)
        {
            InsertTxt("5");
        }

        private void lb4_Click(object sender, EventArgs e)
        {
            InsertTxt("4");
        }

        private void lb7_Click(object sender, EventArgs e)
        {
            InsertTxt("7");
        }

        private void lbTui_Click(object sender, EventArgs e)
        {
            
            if (txtVipTel.Focused)
            {
                string msg = txtVipTel.Text;
                txtVipTel.Text = msg.Substring(0, msg.Length - 1);
            }
            if (txtVipPwd.Focused)
            {
                string msg = txtVipPwd.Text;
                txtVipPwd.Text = msg.Substring(0, msg.Length - 1);
            }
        }

        private void lbQin_Click(object sender, EventArgs e)
        {
            if (txtVipTel.Focused)
            {
                txtVipTel.Text = "";
            }
            if (txtVipPwd.Focused)
            {
                txtVipPwd.Text = "";
            }
        }
        #region 输入完整性
        private bool CheckInfo()
        {
            if (txtVipPwd.Text == "")
            {
                Transmit.FrmFoodMain.Tipsk("密码为空！");

                txtVipPwd.Focus();
                return false;
            }
            if (txtVipTel.Text == "")
            {
                Transmit.FrmFoodMain.Tipsk("手机号有误！");
                txtVipTel.Focus();
                return false;
            }
            return true;
        }
        #endregion
        private void sbtnOk_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                List<Member> mb = MemberManager.SelectMemberTelbyAll(txtVipTel.Text);
                if (mb.Count>0)
                {
                    //string MemTel = mb[0].MemTel;
                    string MemPwd = mb[0].MemPwd;
                    if (MemPwd ==txtVipPwd.Text)
                    {
                        Transmit.FrmFoodMain.llbVIP.Text = txtVipTel.Text;
                        Transmit.FrmFoodMain.Tipsk("欢迎回来！会员");
                        this.Close();
                    }
                }
                else
                {
                    Transmit.FrmFoodMain.Tipsk("该手机号不是会员！");
                }
            }
        }
    }
}
