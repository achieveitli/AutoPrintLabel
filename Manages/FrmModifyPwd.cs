using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manages
{
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private const string MessageHead = "信息提示！";
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
                if (this.txtOldPwd.Text.Equals("") || this.txtOldPwd.Text == null)
                {
                    MessageBox.Show("旧密码不能空！", MessageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (this.txtNewPwd.Text.Equals("") || this.txtNewPwd.Text == null)
                {
                    MessageBox.Show("新密码不能空！", MessageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (this.txtNewPwd2.Text.Equals("") || this.txtNewPwd2.Text == null)
                {
                    MessageBox.Show("重输密码不能空！", MessageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!(this.txtNewPwd.Text.Equals(this.txtNewPwd2.Text)))
                {
                    MessageBox.Show("2次密码输入不一致！", MessageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            if (MessageBox.Show("你确定要修改密码？", MessageHead, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show(" 密码修改完成。", MessageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmModifyPwd_Load(object sender, EventArgs e)
        {

        }
    }
}
