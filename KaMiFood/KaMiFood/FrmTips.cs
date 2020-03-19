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
    public partial class FrmTips : Form
    {
        public FrmTips()
        {
            InitializeComponent();
        }
        public bool Ok = false;
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

        private void lbTips_Click(object sender, EventArgs e)
        {

        }
    }
}
