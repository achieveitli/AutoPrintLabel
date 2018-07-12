using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using BllImpl;
using Entity;


namespace Manages
{
    public partial class FrmMain : Form
    {
        private ILogInBll bll = null;
        //登录次数
        private int LogInCount=0;
        public FrmMain()
        {
            InitializeComponent();
            bll = new LogInBllImpl();
        }
        private const string messageHead = "信息提示！";

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogInCount++;
            if (LogInCount>5)
            {
                MessageBox.Show("你是在捣乱的把！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            if (txtAccount.Text!=null&&txtAccount.Text.Equals(""))
            {
                MessageBox.Show("用户不能为空！",messageHead,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtPwd.Text!=null && txtPwd.Text.Equals(""))
            {
                MessageBox.Show("密码不能为空！",messageHead,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            b_User user=new b_User();
            user.cPassword = txtPwd.Text;
            user.cUser_Id = txtAccount.Text;
            //验证用户和密码在数据库里面有没有才可以登录。
            //MessageBox.Show("登录进来了。", "信息提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Boolean req = bll.Login(user);
            if (bll.Login(user))
            {
                FrmMainBoy boy = new FrmMainBoy();
                boy.showlogin += new Manages.FrmMainBoy.ShowLogin(ShowLonin);
                this.Hide();
                boy.Show();
            }
            else
            {
                MessageBox.Show("账号或密码错误！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        
        }

      

        void boy_showlogin()
        {
            throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            this.txtPwd.Text = "";
        }

        //显示这个窗体
        public void ShowLonin()
        {
            this.txtAccount.Text = "";
            this.txtPwd.Text = "";
            this.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
