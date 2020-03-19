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
using AddFood;

namespace Food
{
    public partial class StaffInfoManager : UserControl
    {
        public StaffInfoManager()
        {
            InitializeComponent();
        }

        private void StaffInfoManager_Load(object sender, EventArgs e)
        {
            Transmit.StaffInfoManager = this;
            FrmStaffInfo StaffInfo = new FrmStaffInfo();
            StaffInfo.Show();
            plStaffInfo.Controls.Clear();
            plStaffInfo.Controls.Add(StaffInfo);           
        }
        private void tsmiFindStaff_Click(object sender, EventArgs e)
        {
                //UserManager user = new UserManager(this);
                //user.Show();
                //plStaffInfo.Controls.Clear();
               // plStaffInfo.Controls.Add(user);
        }
    }
}
