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
using System.Security.Policy;
using System.Runtime.InteropServices;

namespace AddFood
{
    public partial class FrmLogin : Skin_DevExpress
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            L1.BorderColor = Color.Gold;
        }

        private void txtLoginId_MouseDown(object sender, MouseEventArgs e)
        {
            L1.BorderColor = Color.Gold;
            L2.BorderColor = Color.Black;
        }
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            L1.BorderColor = Color.Black;
            L2.BorderColor = Color.Gold;
        }
        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            txtLoginId.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMain FM = new FrmMain();
            Hide();FM.Show();

        }
    }
}
