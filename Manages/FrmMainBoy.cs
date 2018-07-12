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
    public partial class FrmMainBoy : Form
    {
        public FrmMainBoy()
        {
            InitializeComponent();
        }
        public delegate void ShowLogin();

        public event ShowLogin showlogin;

        private const string messageHead = "信息提示！";


        //打印标签
        FrmPrintLabels print = null;
        //生成标签
        private FrmCreateLabels create;

        //保存用户名
        private string _userID;

        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }


        private void tsmiExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出程序？",messageHead,MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsmiLogour_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要注销？",messageHead,MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                showlogin();
                this.Close();
            } 
        }

        private void FrmMainBoy_Load(object sender, EventArgs e)
        {

        }

        private void FrmMainBoy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd pwd = new FrmModifyPwd();
            pwd.MdiParent = this;
            pwd.Show();
        }

        /// <summary>
        /// 打印标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiPrintLabel_Click(object sender, EventArgs e)
        {

            FrmPrintLabels printLabels = FrmPrintLabels.getFrmPrintLabelsSingle();
            printLabels.MdiParent = this;
            printLabels.BringToFront();
            printLabels.Show();
           

        }

        /// <summary>
        /// 生成标签
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCreateLabels_Click(object sender, EventArgs e)
        {
            FrmCreateLabels createLabels = FrmCreateLabels.getSingle();
            createLabels.MdiParent = this;
            createLabels.BringToFront();
            createLabels.Show();

        }
        /// <summary>
        /// 标签生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnCreateLabels_Click(object sender, EventArgs e)
        {
            this.tsmiCreateLabels_Click(sender, e);
        }
    }
}
