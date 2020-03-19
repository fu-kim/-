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
    public partial class FrmTextActivityInfo : UserControl
    {
        string[] color = new string[] { "red", "blue", "Purple" };
        int i = 0;
        public FrmTextActivityInfo()
        {
            InitializeComponent();
        }
        #region 文本活动信息
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (i == color.Length - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            lbTextActivity.ForeColor = Color.FromName(color[i]);
            
        }
        #endregion
    }
}
