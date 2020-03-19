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

namespace Food
{
    public partial class FrmAssociator : UserControl
    {
        public FrmAssociator()
        {
            InitializeComponent();
        }

        private void FrmAssociator_Load(object sender, EventArgs e)
        {
            SdgvMemberInfo.DataSource = MemberManager.SelectMemberAll();
        }

        private void SdgvMemberInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SdgvMemberInfo.SelectedRows.Count>0)
            {
                stxtMemberId.Text = SdgvMemberInfo.SelectedRows[0].Cells["clMemberId"].Value.ToString();
                stxtMemberName.Text = SdgvMemberInfo.SelectedRows[0].Cells["clMemName"].Value.ToString();
                stxtMemberAge.Text = SdgvMemberInfo.SelectedRows[0].Cells["clMemAge"].Value.ToString();
                stxtMemberPwd.Text = SdgvMemberInfo.SelectedRows[0].Cells["clMemPwd"].Value.ToString();
                stxtMemberTel.Text = SdgvMemberInfo.SelectedRows[0].Cells["clMemTel"].Value.ToString();
                sdtpOpenCard.Text = SdgvMemberInfo.SelectedRows[0].Cells["clMemBirthday"].Value.ToString();
                scboSex.Text = SdgvMemberInfo.SelectedRows[0].Cells["clMemSex"].Value.ToString();
            }
        }

        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            if (stxtMemberTel.Text!="")
            {
                if (MemberManager.SelectMemberTel(stxtMemberTel.Text))
                {
                    int n = MemberManager.InsertMember(stxtMemberName.Text, stxtMemberTel.Text, stxtMemberPwd.Text, scboSex.Text, stxtMemberAge.Text, Convert.ToDateTime(sdtpOpenCard.Text));
                    if (n > 0)
                    {
                        MessageBox.Show("添加成功");
                        FrmAssociator_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("会员已存在，不可重复添加", "会员提示");
                }
            }
            else
            {
                MessageBox.Show("请输入会员的电话号码", "会员提示");
            }
        }

        private void sbtnUpdate_Click(object sender, EventArgs e)
        {
            if (stxtMemberId.Text!="")
            {
                int n = MemberManager.UpdateMember(Convert.ToInt32(stxtMemberId.Text), stxtMemberName.Text, stxtMemberTel.Text, stxtMemberPwd.Text, scboSex.Text, stxtMemberAge.Text, Convert.ToDateTime(sdtpOpenCard.Text));
                if (n > 0)
                {
                    MessageBox.Show("修改成功");
                    FrmAssociator_Load(sender, e);
                }

            }
            else
            {
                MessageBox.Show("请选择你要修改的会员", "会员提示");
            }

        }

        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (stxtMemberId.Text != "")
            {
                int n = MemberManager.DeleteMember(Convert.ToInt32(stxtMemberId.Text));
                if (n > 0)
                {
                    MessageBox.Show("删除成功");
                    FrmAssociator_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("请选择你要删除的会员", "会员提示");
            }
        }

        private void sbtnFind_Click(object sender, EventArgs e)
        {
            if (stxtMemberTel.Text != "")
            {
                if (MemberManager.SelectMemberTelbyAll(stxtMemberTel.Text).Count>0)
                {
                    SdgvMemberInfo.DataSource = MemberManager.SelectMemberTelbyAll(stxtMemberTel.Text);
                }
                else
                {
                    MessageBox.Show("未查找到会员电话", "会员提示");
                    FrmAssociator_Load(sender, e);
                }
                
            }
            else
            {
                MessageBox.Show("请输入你要查找的会员电话", "会员提示");
            }
        }
    }
}
