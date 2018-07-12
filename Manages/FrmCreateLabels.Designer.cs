namespace Manages
{
    partial class FrmCreateLabels
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPackCode = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtReel = new System.Windows.Forms.TextBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.txtMaxBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtZhuShen = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtFlowCardSuffix = new System.Windows.Forms.TextBox();
            this.txtBatchSuffix = new System.Windows.Forms.TextBox();
            this.txtFlowCard = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMaxBoxQTY = new System.Windows.Forms.TextBox();
            this.txtBoxQTY = new System.Windows.Forms.TextBox();
            this.txtReelQTY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtFoot = new System.Windows.Forms.TextBox();
            this.txtTypeCode = new System.Windows.Forms.TextBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtCinvName = new System.Windows.Forms.TextBox();
            this.txtCinvstd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDpredate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMainClaim = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDetailClaim = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_CopyOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_pack = new System.Windows.Forms.CheckBox();
            this.cb_reel = new System.Windows.Forms.CheckBox();
            this.btnCreateAndPrint = new System.Windows.Forms.Button();
            this.txtCreateQTY = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "条码：";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(253, 29);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(187, 26);
            this.txtCode.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(586, 20);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 50);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(682, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 36);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "生成(&C)";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCreateQTY);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtPackCode);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtReel);
            this.groupBox1.Controls.Add(this.txtBox);
            this.groupBox1.Controls.Add(this.txtMaxBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标签生成数量";
            // 
            // txtPackCode
            // 
            this.txtPackCode.Location = new System.Drawing.Point(675, 23);
            this.txtPackCode.Name = "txtPackCode";
            this.txtPackCode.ReadOnly = true;
            this.txtPackCode.Size = new System.Drawing.Size(58, 26);
            this.txtPackCode.TabIndex = 15;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(614, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 16);
            this.label26.TabIndex = 14;
            this.label26.Text = "包装码：";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(804, 23);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(144, 26);
            this.txtKey.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(742, 26);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 16);
            this.label24.TabIndex = 12;
            this.label24.Text = "条码：";
            // 
            // txtReel
            // 
            this.txtReel.Location = new System.Drawing.Point(355, 23);
            this.txtReel.Name = "txtReel";
            this.txtReel.ReadOnly = true;
            this.txtReel.Size = new System.Drawing.Size(63, 26);
            this.txtReel.TabIndex = 10;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(225, 23);
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(62, 26);
            this.txtBox.TabIndex = 9;
            // 
            // txtMaxBox
            // 
            this.txtMaxBox.Location = new System.Drawing.Point(88, 23);
            this.txtMaxBox.Name = "txtMaxBox";
            this.txtMaxBox.ReadOnly = true;
            this.txtMaxBox.Size = new System.Drawing.Size(59, 26);
            this.txtMaxBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "卷盘：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "内盒：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "外箱：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtZhuShen);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtFlowCardSuffix);
            this.groupBox2.Controls.Add(this.txtBatchSuffix);
            this.groupBox2.Controls.Add(this.txtFlowCard);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtMaxBoxQTY);
            this.groupBox2.Controls.Add(this.txtBoxQTY);
            this.groupBox2.Controls.Add(this.txtReelQTY);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.txtFoot);
            this.groupBox2.Controls.Add(this.txtTypeCode);
            this.groupBox2.Controls.Add(this.txtBatch);
            this.groupBox2.Controls.Add(this.txtCinvName);
            this.groupBox2.Controls.Add(this.txtCinvstd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 139);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产品信息";
            // 
            // txtZhuShen
            // 
            this.txtZhuShen.Location = new System.Drawing.Point(408, 59);
            this.txtZhuShen.Name = "txtZhuShen";
            this.txtZhuShen.ReadOnly = true;
            this.txtZhuShen.Size = new System.Drawing.Size(109, 26);
            this.txtZhuShen.TabIndex = 28;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(345, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 16);
            this.label25.TabIndex = 27;
            this.label25.Text = "封装：";
            // 
            // txtFlowCardSuffix
            // 
            this.txtFlowCardSuffix.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFlowCardSuffix.Location = new System.Drawing.Point(620, 97);
            this.txtFlowCardSuffix.Name = "txtFlowCardSuffix";
            this.txtFlowCardSuffix.Size = new System.Drawing.Size(125, 26);
            this.txtFlowCardSuffix.TabIndex = 26;
            // 
            // txtBatchSuffix
            // 
            this.txtBatchSuffix.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBatchSuffix.Location = new System.Drawing.Point(290, 97);
            this.txtBatchSuffix.Name = "txtBatchSuffix";
            this.txtBatchSuffix.Size = new System.Drawing.Size(107, 26);
            this.txtBatchSuffix.TabIndex = 25;
            // 
            // txtFlowCard
            // 
            this.txtFlowCard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFlowCard.Location = new System.Drawing.Point(466, 97);
            this.txtFlowCard.Name = "txtFlowCard";
            this.txtFlowCard.ReadOnly = true;
            this.txtFlowCard.Size = new System.Drawing.Size(148, 26);
            this.txtFlowCard.TabIndex = 24;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(403, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 16);
            this.label22.TabIndex = 23;
            this.label22.Text = "流程卡：";
            // 
            // txtMaxBoxQTY
            // 
            this.txtMaxBoxQTY.Location = new System.Drawing.Point(848, 97);
            this.txtMaxBoxQTY.Name = "txtMaxBoxQTY";
            this.txtMaxBoxQTY.ReadOnly = true;
            this.txtMaxBoxQTY.Size = new System.Drawing.Size(100, 26);
            this.txtMaxBoxQTY.TabIndex = 22;
            // 
            // txtBoxQTY
            // 
            this.txtBoxQTY.Location = new System.Drawing.Point(848, 61);
            this.txtBoxQTY.Name = "txtBoxQTY";
            this.txtBoxQTY.ReadOnly = true;
            this.txtBoxQTY.Size = new System.Drawing.Size(100, 26);
            this.txtBoxQTY.TabIndex = 21;
            // 
            // txtReelQTY
            // 
            this.txtReelQTY.Location = new System.Drawing.Point(848, 26);
            this.txtReelQTY.Name = "txtReelQTY";
            this.txtReelQTY.ReadOnly = true;
            this.txtReelQTY.Size = new System.Drawing.Size(100, 26);
            this.txtReelQTY.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(751, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "外箱数量：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(750, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "内盒数量：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(751, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "卷盘数量：";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNote.Location = new System.Drawing.Point(597, 26);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(148, 26);
            this.txtNote.TabIndex = 12;
            // 
            // txtFoot
            // 
            this.txtFoot.Location = new System.Drawing.Point(597, 61);
            this.txtFoot.Name = "txtFoot";
            this.txtFoot.ReadOnly = true;
            this.txtFoot.Size = new System.Drawing.Size(148, 26);
            this.txtFoot.TabIndex = 11;
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.Location = new System.Drawing.Point(358, 26);
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.ReadOnly = true;
            this.txtTypeCode.Size = new System.Drawing.Size(159, 26);
            this.txtTypeCode.TabIndex = 10;
            // 
            // txtBatch
            // 
            this.txtBatch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBatch.Location = new System.Drawing.Point(91, 97);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(193, 26);
            this.txtBatch.TabIndex = 9;
            // 
            // txtCinvName
            // 
            this.txtCinvName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCinvName.Location = new System.Drawing.Point(121, 61);
            this.txtCinvName.Name = "txtCinvName";
            this.txtCinvName.ReadOnly = true;
            this.txtCinvName.Size = new System.Drawing.Size(218, 26);
            this.txtCinvName.TabIndex = 8;
            // 
            // txtCinvstd
            // 
            this.txtCinvstd.Location = new System.Drawing.Point(121, 26);
            this.txtCinvstd.Name = "txtCinvstd";
            this.txtCinvstd.ReadOnly = true;
            this.txtCinvstd.Size = new System.Drawing.Size(148, 26);
            this.txtCinvstd.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "RMK：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "脚型：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "产品编码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "批号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "产品名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "产品型号：";
            // 
            // txtDpredate
            // 
            this.txtDpredate.Location = new System.Drawing.Point(382, 104);
            this.txtDpredate.Name = "txtDpredate";
            this.txtDpredate.ReadOnly = true;
            this.txtDpredate.Size = new System.Drawing.Size(168, 26);
            this.txtDpredate.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "出货日期：";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(309, 24);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(148, 26);
            this.txtOrder.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "订单：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtOrderQty);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtMainClaim);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtDetailClaim);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtDpredate);
            this.groupBox3.Controls.Add(this.txtOrder);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtClientCode);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtPO);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtPN);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(12, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(960, 189);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "订单信息";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemark.Location = new System.Drawing.Point(648, 74);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemark.Size = new System.Drawing.Size(300, 49);
            this.txtRemark.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(586, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 20;
            this.label23.Text = "备注：";
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrderQty.Location = new System.Drawing.Point(382, 64);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.ReadOnly = true;
            this.txtOrderQty.Size = new System.Drawing.Size(168, 26);
            this.txtOrderQty.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(287, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "订单数量：";
            // 
            // txtMainClaim
            // 
            this.txtMainClaim.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMainClaim.Location = new System.Drawing.Point(648, 130);
            this.txtMainClaim.Multiline = true;
            this.txtMainClaim.Name = "txtMainClaim";
            this.txtMainClaim.ReadOnly = true;
            this.txtMainClaim.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMainClaim.Size = new System.Drawing.Size(300, 47);
            this.txtMainClaim.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(571, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 16;
            this.label20.Text = "客户要求：";
            // 
            // txtDetailClaim
            // 
            this.txtDetailClaim.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDetailClaim.Location = new System.Drawing.Point(648, 21);
            this.txtDetailClaim.Multiline = true;
            this.txtDetailClaim.Name = "txtDetailClaim";
            this.txtDetailClaim.ReadOnly = true;
            this.txtDetailClaim.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetailClaim.Size = new System.Drawing.Size(300, 47);
            this.txtDetailClaim.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(568, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 14;
            this.label19.Text = "明细要求：";
            // 
            // txtClientCode
            // 
            this.txtClientCode.Location = new System.Drawing.Point(120, 24);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.ReadOnly = true;
            this.txtClientCode.Size = new System.Drawing.Size(120, 26);
            this.txtClientCode.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "客户编码：";
            // 
            // txtPO
            // 
            this.txtPO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPO.Location = new System.Drawing.Point(72, 102);
            this.txtPO.Name = "txtPO";
            this.txtPO.ReadOnly = true;
            this.txtPO.Size = new System.Drawing.Size(196, 26);
            this.txtPO.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "PO：";
            // 
            // txtPN
            // 
            this.txtPN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPN.Location = new System.Drawing.Point(72, 64);
            this.txtPN.Name = "txtPN";
            this.txtPN.ReadOnly = true;
            this.txtPN.Size = new System.Drawing.Size(196, 26);
            this.txtPN.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "PN：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_CopyOrder,
            this.toolStripMenuItem2,
            this.ToolStripMenuItem_Create});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 54);
            // 
            // ToolStripMenuItem_CopyOrder
            // 
            this.ToolStripMenuItem_CopyOrder.Name = "ToolStripMenuItem_CopyOrder";
            this.ToolStripMenuItem_CopyOrder.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_CopyOrder.Text = "拷贝订单";
            this.ToolStripMenuItem_CopyOrder.Click += new System.EventHandler(this.ToolStripMenuItem_CopyOrder_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // ToolStripMenuItem_Create
            // 
            this.ToolStripMenuItem_Create.Enabled = false;
            this.ToolStripMenuItem_Create.Name = "ToolStripMenuItem_Create";
            this.ToolStripMenuItem_Create.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_Create.Text = "生成";
            this.ToolStripMenuItem_Create.Click += new System.EventHandler(this.ToolStripMenuItem_Create_Click);
            // 
            // cb_pack
            // 
            this.cb_pack.AutoSize = true;
            this.cb_pack.Location = new System.Drawing.Point(455, 21);
            this.cb_pack.Name = "cb_pack";
            this.cb_pack.Size = new System.Drawing.Size(107, 20);
            this.cb_pack.TabIndex = 6;
            this.cb_pack.Text = "只生成内盒";
            this.cb_pack.UseVisualStyleBackColor = true;
            this.cb_pack.CheckedChanged += new System.EventHandler(this.cb_pack_CheckedChanged);
            // 
            // cb_reel
            // 
            this.cb_reel.AutoSize = true;
            this.cb_reel.Location = new System.Drawing.Point(455, 47);
            this.cb_reel.Name = "cb_reel";
            this.cb_reel.Size = new System.Drawing.Size(107, 20);
            this.cb_reel.TabIndex = 7;
            this.cb_reel.Text = "只生成卷盘";
            this.cb_reel.UseVisualStyleBackColor = true;
            this.cb_reel.CheckedChanged += new System.EventHandler(this.cb_reel_CheckedChanged);
            // 
            // btnCreateAndPrint
            // 
            this.btnCreateAndPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAndPrint.Enabled = false;
            this.btnCreateAndPrint.Location = new System.Drawing.Point(682, 44);
            this.btnCreateAndPrint.Name = "btnCreateAndPrint";
            this.btnCreateAndPrint.Size = new System.Drawing.Size(110, 35);
            this.btnCreateAndPrint.TabIndex = 8;
            this.btnCreateAndPrint.Text = "生成并打印";
            this.btnCreateAndPrint.UseVisualStyleBackColor = true;
            this.btnCreateAndPrint.Click += new System.EventHandler(this.btnCreateAndPrint_Click);
            // 
            // txtCreateQTY
            // 
            this.txtCreateQTY.Location = new System.Drawing.Point(508, 23);
            this.txtCreateQTY.Name = "txtCreateQTY";
            this.txtCreateQTY.ReadOnly = true;
            this.txtCreateQTY.Size = new System.Drawing.Size(100, 26);
            this.txtCreateQTY.TabIndex = 17;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(424, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 16);
            this.label27.TabIndex = 16;
            this.label27.Text = "生成数量：";
            // 
            // FrmCreateLabels
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnCreateAndPrint);
            this.Controls.Add(this.cb_reel);
            this.Controls.Add(this.cb_pack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.Name = "FrmCreateLabels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "标签生成";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCreateLabels_FormClosed);
            this.Load += new System.EventHandler(this.FrmCreateLabels_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReel;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox txtMaxBox;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtCinvName;
        private System.Windows.Forms.TextBox txtCinvstd;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtFoot;
        private System.Windows.Forms.TextBox txtTypeCode;
        private System.Windows.Forms.TextBox txtDpredate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaxBoxQTY;
        private System.Windows.Forms.TextBox txtBoxQTY;
        private System.Windows.Forms.TextBox txtReelQTY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMainClaim;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDetailClaim;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CopyOrder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Create;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TextBox txtFlowCard;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBatchSuffix;
        private System.Windows.Forms.TextBox txtFlowCardSuffix;
        private System.Windows.Forms.CheckBox cb_pack;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtZhuShen;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox cb_reel;
        private System.Windows.Forms.TextBox txtPackCode;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnCreateAndPrint;
        private System.Windows.Forms.TextBox txtCreateQTY;
        private System.Windows.Forms.Label label27;
    }
}