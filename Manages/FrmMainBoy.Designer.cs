namespace Manages
{
    partial class FrmMainBoy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainBoy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogour = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrintLabels = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreateLabels = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnCreateLabels = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSystem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msSystem
            // 
            this.msSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyPwd,
            this.tsmiLogour,
            this.tsmiExit});
            this.msSystem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msSystem.Name = "msSystem";
            this.msSystem.Size = new System.Drawing.Size(52, 20);
            this.msSystem.Text = "系统";
            // 
            // tsmiModifyPwd
            // 
            this.tsmiModifyPwd.Name = "tsmiModifyPwd";
            this.tsmiModifyPwd.Size = new System.Drawing.Size(140, 22);
            this.tsmiModifyPwd.Text = "修改密码";
            this.tsmiModifyPwd.Click += new System.EventHandler(this.tsmiModifyPwd_Click);
            // 
            // tsmiLogour
            // 
            this.tsmiLogour.Name = "tsmiLogour";
            this.tsmiLogour.Size = new System.Drawing.Size(140, 22);
            this.tsmiLogour.Text = "注销";
            this.tsmiLogour.Click += new System.EventHandler(this.tsmiLogour_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(140, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrintLabels,
            this.tsmiCreateLabels});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "标签";
            // 
            // tsmiPrintLabels
            // 
            this.tsmiPrintLabels.Name = "tsmiPrintLabels";
            this.tsmiPrintLabels.Size = new System.Drawing.Size(140, 22);
            this.tsmiPrintLabels.Text = "打印标签";
            this.tsmiPrintLabels.Click += new System.EventHandler(this.tsmiPrintLabel_Click);
            // 
            // tsmiCreateLabels
            // 
            this.tsmiCreateLabels.Name = "tsmiCreateLabels";
            this.tsmiCreateLabels.Size = new System.Drawing.Size(140, 22);
            this.tsmiCreateLabels.Text = "生成标签";
            this.tsmiCreateLabels.Click += new System.EventHandler(this.tsmiCreateLabels_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCreateLabels,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(941, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnCreateLabels
            // 
            this.tsbtnCreateLabels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCreateLabels.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnCreateLabels.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCreateLabels.Image")));
            this.tsbtnCreateLabels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCreateLabels.Name = "tsbtnCreateLabels";
            this.tsbtnCreateLabels.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCreateLabels.Text = "生成标签";
            this.tsbtnCreateLabels.Click += new System.EventHandler(this.tsbtnCreateLabels_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "打印标签";
            this.toolStripButton1.Click += new System.EventHandler(this.tsmiPrintLabel_Click);
            // 
            // FrmMainBoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 532);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainBoy";
            this.Text = "标签打印系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainBoy_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainBoy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogour;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrintLabels;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateLabels;
        private System.Windows.Forms.ToolStripButton tsbtnCreateLabels;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}