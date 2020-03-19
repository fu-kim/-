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
using Models;

namespace Food
{
   
    public partial class FrmStaffInfo : UserControl
    {
        public FrmStaffInfo()
        {
            InitializeComponent();
        }
        public void LoadDgv()
        {
            dgvMain.AutoGenerateColumns = false;
            dgvMain.DataSource = StaffManager.SelectStaffAll();
        }
        private void FrmStaffInfo_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void tsmiFindStaff_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedCells.Count>0)
            {
                Transmit.StaffInfoManager.plStaffInfo.Controls.Clear();
                string id = dgvMain.SelectedRows[0].Cells[0].Value.ToString();
                UserManager frm = new UserManager(this);
                frm.StaffId = id;
                Transmit.StaffInfoManager.plStaffInfo.Controls.Add(frm);
            }
               
        }

        private void tsmiAddStaff_Click(object sender, EventArgs e)
        {
            Transmit.StaffInfoManager.plStaffInfo.Controls.Clear();
            UserManager frm = new UserManager(this);
            frm.Show();
            frm.btnReset_Click_1(sender,e);
            Transmit.StaffInfoManager.plStaffInfo.Controls.Add(frm);
        }
    }
}
