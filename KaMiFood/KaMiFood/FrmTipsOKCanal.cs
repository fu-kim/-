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
    public partial class FrmTipsOKCancel : Form
    {
        public FrmTipsOKCancel()
        {
            InitializeComponent();
        }
        public bool Ok = false;
        private void pbxCancel_MouseMove(object sender, MouseEventArgs e)
        {
            pbxCancel.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\Cancel选中.png");
        }

        private void pbxCancel_MouseLeave(object sender, EventArgs e)
        {
            pbxCancel.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\Cancel.png");
        }

        private void pbxOK_MouseMove(object sender, MouseEventArgs e)
        {
            pbxOK.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\OK选中.png");
        }

        private void pbxOK_MouseLeave(object sender, EventArgs e)
        {
            pbxOK.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\OK.png");
        }

        private void pbxOK_Click(object sender, EventArgs e)
        {
            Ok = true;
            this.Close();
        }

        private void pbxCancel_Click(object sender, EventArgs e)
        {
            Ok = false;
            this.Close();
        }
    }
}
