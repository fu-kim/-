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
    public partial class FrmTable : UserControl
    {
        public FrmTable()
        {
            InitializeComponent();
        }
        public List<Table> IsService = new List<Table>();
        public List<Table> IsServiceType = new List<Table>();
        public void FrmTable_Load(object sender, EventArgs e)
        {
            flpTableInfo.Controls.Clear();
            Transmit.FrmTable = this;
            int k = 0;
            int d = 0;
            int w = 0;
            int z = 0;
            int c = 0;
            List<Table> tb = TableManager.SelectTableAll();
            for (int i = 0; i < tb.Count; i++)
            {
                int type = tb[i].TableTypeId;
                FrmTableInfo fti = new FrmTableInfo();
                fti.lbTableId.Text = tb[i].TableId.ToString();
                switch (type)
                {
                    case 1: fti.pbxTableType.BackColor = Color.MediumSpringGreen; ++k; break;
                    case 2: fti.pbxTableType.BackColor = Color.Goldenrod; ++d; break;
                    case 3: fti.pbxTableType.BackColor = Color.Tomato; ++z; break;
                    case 4: fti.pbxTableType.BackColor = Color.Silver;++w ; break;
                    case 5: fti.pbxTableType.BackColor = Color.DeepSkyBlue; ++c; break;
                }
                flpTableInfo.Controls.Add(fti);

            }
            lbKongZhuo.Text = k.ToString();
            lbDaSao.Text = d.ToString();
            lbWeiXiu.Text = w.ToString();
            lbZhanYong.Text = z.ToString();
            lbDianCai.Text = c.ToString();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            IsService = TableManager.SelectTableIsService();
            int k = 0;
            int d = 0;
            int w = 0;
            int z = 0;
            int c = 0;
            List<Table> tb = TableManager.SelectTableAll();
            for (int i = 0; i < tb.Count; i++)
            {
                int type = tb[i].TableTypeId;
                switch (type)
                {
                    case 1: ++k; break;
                    case 2: ++d; break;
                    case 3: ++z; break;
                    case 4: ++w; break;
                    case 5: ++c; break;
                }
            }
            lbKongZhuo.Text = k.ToString();
            lbDaSao.Text = d.ToString();
            lbWeiXiu.Text = w.ToString();
            lbZhanYong.Text = z.ToString();
            lbDianCai.Text = c.ToString();
        }
    }
}
