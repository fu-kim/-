using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaMiFood
{
    public partial class FrmCActivityInfo : UserControl
    {
        public FrmCActivityInfo()
        {
            InitializeComponent();
        }

        private void FrmCActivityInfo_Load(object sender, EventArgs e)
        {
            Transmit.FrmCActivityInfo = this;
        }
    }
}
