using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bll;
using BllImpl;
using Entity;

namespace Manages
{
    public partial class FrmCreateLabels : Form
    {
        private static FrmCreateLabels frmCreateLabels = null;
        private IOpenCardPackBll openCardPackBll = null;
        private ISoMainBll soMainBll = null;
        private IFrmCreateLabelsBll frmCreateLabelsBll = null;
        private const string messageHead = "提示";
        private IPrintLabelsBll printLabelsBll = null;
        private FrmCreateLabels()
        {
            InitializeComponent();
            openCardPackBll = new OpenCardPackBllImpl();
            soMainBll = new SoMainBllImpl();
            frmCreateLabelsBll = new FrmCreatelabelsBllImpl();
            printLabelsBll = new PrintLabelsBllImpl();
        }

        public static FrmCreateLabels getSingle()
        {
            if (frmCreateLabels == null)
            {
                frmCreateLabels = new FrmCreateLabels();
            }
            return frmCreateLabels;
        }

        private void FrmCreateLabels_Load(object sender, EventArgs e)
        {
            ActiveControl = this.txtCode;
        }
        /// <summary>
        /// 查询标签信息按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            ClearGroupBoxText();
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                t_opencardpack parmOpencardpack = new t_opencardpack();
                parmOpencardpack.Fbarcode = txtCode.Text.Trim().ToString();
                t_opencardpack newOpencardpack = openCardPackBll.FindOpencardpackByCode(parmOpencardpack);
                if (newOpencardpack != null)
                {
                    if (newOpencardpack.Flabelqty==null)
                    {
                        MessageBox.Show(@"生成数量为空，请返回开卡包装规格设置！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    this.txtBatch.Text = NullTurnEmpty(newOpencardpack.FBatchNoall);
                    this.txtCinvstd.Text = NullTurnEmpty(newOpencardpack.cinvstd);
                    this.txtCinvName.Text = NullTurnEmpty(newOpencardpack.cinvname);
                    this.txtClientCode.Text = NullTurnEmpty(newOpencardpack.cCusCode);
                    this.txtOrder.Text = NullTurnEmpty(newOpencardpack.cSOCode);
                    this.txtZhuShen.Text = NullTurnEmpty(newOpencardpack.Fzhushen);
                    this.txtTypeCode.Text = NullTurnEmpty(newOpencardpack.FProductNo);
                    this.txtFoot.Text = NullTurnEmpty(newOpencardpack.ffoot);
                    this.txtDpredate.Text = NullTurnEmpty(newOpencardpack.dPreDate.ToString());
                    this.txtPN.Text = NullTurnEmpty(newOpencardpack.cPN);
                    this.txtPO.Text = NullTurnEmpty(newOpencardpack.cPO);
                    this.txtCreateQTY.Text = (Double.Parse(newOpencardpack.Flabelqty.ToString()) * 1000).ToString(CultureInfo.InvariantCulture);
                    this.txtOrderQty.Text = (Double.Parse(newOpencardpack.Fqty.ToString()) * 1000).ToString(CultureInfo.InvariantCulture);
                    this.txtFlowCard.Text = NullTurnEmpty(newOpencardpack.Fsn);
                    this.txtKey.Text = this.txtCode.Text.Trim().ToUpper();
                    this.txtBatchSuffix.Text = NullTurnEmpty(newOpencardpack.Fbatchfree);
                    this.txtFlowCardSuffix.Text = NullTurnEmpty(newOpencardpack.fsnfree);
                    if (!string.IsNullOrEmpty(newOpencardpack.CNC))
                    {
                        this.txtFlowCardSuffix.Text = this.txtFlowCardSuffix.Text + @" " + newOpencardpack.CNC;
                    }
                    this.txtNote.Text = NullTurnEmpty(newOpencardpack.Fnote);
                    this.txtRemark.Text = NullTurnEmpty(newOpencardpack.cFree1);
                    //获取主订单信息
                    SO_SOMain soMain = soMainBll.FindSoMainByCsoCode(NullTurnEmpty(newOpencardpack.cSOCode));
                    if (soMain != null)
                    {
                        this.txtMainClaim.Text = NullTurnEmpty(soMain.cMemo);
                    }
                    else
                    {
                        MessageBox.Show(@"此条码订单号为空的！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //获取订单明细信息
                    //SO_SODetails parmSoDetails = new SO_SODetails();
                    //parmSoDetails.cSOCode = newOpencardpack.cSOCode.Trim();
                    //parmSoDetails.cInvCode = newOpencardpack.FProductNo.Trim();
                    //SO_SODetails soDetails = soDetailsBll.FindSoDetailsBySoDetails(parmSoDetails);

                    if (newOpencardpack.FsaID != null)
                    {
                        int sodetailsID = 0;
                        sodetailsID = (int)newOpencardpack.FsaID;
                        if (sodetailsID != 0)
                        {
                            SO_SODetails soDetails = frmCreateLabelsBll.FindSoDetailsById(sodetailsID);
                            if (soDetails != null)
                            {
                                //明细单要求
                                this.txtDetailClaim.Text = soDetails.cMemo.Trim();
                            }
                            else
                            {
                                MessageBox.Show(@"明细订单为空！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"开卡表的明细订单的ID为0!", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show(@"开卡表没有明细订单的ID!", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //获取包装信息
                    if (string.IsNullOrEmpty(newOpencardpack.cPCode))
                    {
                        MessageBox.Show(@"没有选择包装编码！请返回开卡包装规格设置", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    this.txtPackCode.Text = newOpencardpack.cPCode.Trim();
                    SA_Packs saPacks = frmCreateLabelsBll.FindSaPacksBySaPackCode(newOpencardpack.cPCode.Trim());
                    if (saPacks != null)
                    {
                        this.txtReelQTY.Text = (Double.Parse(saPacks.FPKminqty.ToString()) * 1000).ToString();
                        this.txtBoxQTY.Text = (Decimal.ToInt32(saPacks.fSQty) * 1000).ToString();
                        this.txtMaxBoxQTY.Text = (saPacks.fQuantity * 1000).ToString();
                        double createQty = double.Parse(this.txtCreateQTY.Text);
                        int reelCount = 0;
                        if (!this.cb_pack.Checked)
                        {
                            //计算卷盘数量
                           
                            double reel = Double.Parse(saPacks.FPKminqty.ToString()) * 1000;
                            // double a=order%reel;
                            if (createQty % reel != 0)
                            {
                                reelCount = (int)(createQty / reel) + 1;
                            }
                            else
                            {
                                reelCount = (int)(createQty / reel);
                            }  
                        }
                        this.txtReel.Text = reelCount.ToString();
                        int boxCount = 0;
                        if (!this.cb_reel.Checked)
                        {
                            //计算内盒数量
                            boxCount = 0;
                            double box = Double.Parse(saPacks.fSQty.ToString()) * 1000;
                            //double b = order%box;
                            if (createQty % box != 0)
                            {
                                boxCount = (int)(createQty / box) + 1;
                            }
                            else
                            {
                                boxCount = (int)(createQty / box);
                            }
                        }
                        this.txtBox.Text = boxCount.ToString();
                        this.btnCreate.Enabled = true;
                        this.btnCreateAndPrint.Enabled = true;
                        this.ToolStripMenuItem_Create.Enabled = true;
                        this.txtCode.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(@"包装信息为空，请返回开卡包装规格设置！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(@"此条码无效，请检查清楚！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(@"条码不能为空！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //this.txtCode.Text = "";

        }

        private void FrmCreateLabels_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCreateLabels = null;
        }


        //清空界面的TextBox内容
        private void ClearGroupBoxText()
        {
            foreach (Control control in Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl is TextBox)
                        {
                            subControl.Text = "";
                        }
                    }
                }
            }
        }

        private void ToolStripMenuItem_CopyOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"别瞎点了，此功能没开发呢！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 生成标签按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //int TryParseResult = 0;
            //if (!(int.TryParse(this.txtOrderQty.Text.Trim(), out TryParseResult)))
            //{
            //    MessageBox.Show(@"请正确输入数字！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.txtOrderQty.Focus();
            //    return;
            //}
            int createqty = int.Parse(this.txtCreateQTY.Text.Trim());
            //订单数量控制
            Boolean verify = frmCreateLabelsBll.VerifyOrderQty(this.txtOrder.Text.Trim(), this.txtTypeCode.Text.Trim(), createqty);
            if (!verify)
            {
                MessageBox.Show(@"超出订单数量！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int labelTemplateId = 0;
            FrmSelectTemplate frmSelectTemplate = FrmSelectTemplate.GetSingle(
                delegate()
                {
                    string[] tpv = new[] { "T4003", "T4011", "T4017", "T4021", "T4022", "T4027", "T4008", "T4012", "T4016", "T4023" };
                    if (tpv.Contains(this.txtClientCode.Text.Trim()))
                    {
                        return "TPV";
                    }
                    return this.txtClientCode.Text.Trim();
                },
                delegate(int id)
                {
                    labelTemplateId = id;
                }
            );
            frmSelectTemplate.ShowDialog();
            //MessageBox.Show(@"别瞎点了，此功能没开发呢！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (labelTemplateId != 0)
            {
                t_labels label = new t_labels();
                label.clientCode = this.txtClientCode.Text.Trim();
                if (string.IsNullOrEmpty(this.txtBatchSuffix.Text))
                {
                    label.batchNo = this.txtBatch.Text.Trim();
                }
                else
                {
                    label.batchNo = this.txtBatch.Text.Trim() + this.txtBatchSuffix.Text;
                }
                label.code = this.txtKey.Text.Trim();
                //日期这里要优化一下，拿客户端时间有风险   2018-7-12已经处理
                //label.createDate = DateTime.Now.ToString();
                if (string.IsNullOrEmpty(this.txtFlowCardSuffix.Text))
                {
                    label.flowCard = this.txtFlowCard.Text.Trim();
                }
                else
                {
                    label.flowCard = this.txtFlowCard.Text.Trim() + "  " + this.txtFlowCardSuffix.Text;
                }
                label.labelTemplateAddressId = labelTemplateId;
                label.orderCode = this.txtOrder.Text.Trim();
                label.package = this.txtZhuShen.Text.Trim();
                label.pn = this.txtPN.Text.Trim();
                label.po = this.txtPO.Text.Trim();
                label.shipmentDate = this.txtDpredate.Text.Trim();
                label.type = this.txtCinvstd.Text.Trim();
                label.remark = this.txtNote.Text.Trim();
                label.typeCode = this.txtTypeCode.Text.Trim();
                //int labelQty = Int32.Parse(this.txtBox.Text) + Int32.Parse(this.txtReel.Text);
                int orderQty = int.Parse(this.txtOrderQty.Text.Trim());// 订单数量
                int boxQTY = int.Parse(this.txtBoxQTY.Text.Trim());    //内盒数量
                int reelQTY = int.Parse(this.txtReelQTY.Text.Trim());//卷盘数量
                int box = int.Parse(this.txtBox.Text.Trim());  //内盒个数
                int reel = int.Parse(this.txtReel.Text.Trim()); //卷盘个数
                //Label_template labeltempalte = frmCreateLabelsBll.FindLabelTemplateById(labelTemplateId);
                int result = frmCreateLabelsBll.InsertLabel(label, orderQty, boxQTY, reelQTY, box, reel, this.cb_pack.Checked);
                if (result > 0)
                {
                    MessageBox.Show(@"生成成功！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string messages = null;
                    //打印标签
                    //PrintLabels(this.txtKey.Text.Trim(), ref  messages);
                    //SelectLabels();
                    ClearGroupBoxText();
                    this.btnCreate.Enabled = false;
                }
                else
                {
                    MessageBox.Show(@"生成失败！", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //SelectLabels();
                    ClearGroupBoxText();
                    this.btnCreate.Enabled = false;
                }
            }
        }

        private void ToolStripMenuItem_Create_Click(object sender, EventArgs e)
        {
            btnCreate_Click(sender, e);
        }




        //public void SelectLabels()
        //{
        //    this.dgvLabels.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
        //    this.dgvLabels.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
        //    this.dgvLabels.DataSource = frmCreateLabelsBll.FindLabelsesByCod(this.txtKey.Text.Trim());
        //}

        private void cb_pack_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox checkBox = (CheckBox) sender;
                if (checkBox.Checked)
                {
                    this.cb_reel.Checked = false;
                } 
            }
            ClearGroupBoxText();
            this.btnCreate.Enabled = false;
            this.ToolStripMenuItem_Create.Enabled = false;
        }
        public int PrintLabels(string code, ref string message)
        {
            return printLabelsBll.PrintLabel(code, ref message);
        }

        /// <summary>
        /// 将性属null装换为“”
        /// </summary>
        /// <param name="atrr">string</param>
        /// <returns>string</returns>
        public string NullTurnEmpty(string atrr)
        {
            return string.IsNullOrEmpty(atrr) ? "" : atrr.Trim();
        }
        private void cb_reel_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox checkBox = (CheckBox)sender;
                if (checkBox.Checked)
                {
                    this.cb_pack.Checked = false;
                }
            }
            ClearGroupBoxText();
            this.btnCreate.Enabled = false;
            this.ToolStripMenuItem_Create.Enabled = false;
        }

        //订单数量值改变就计算标签生成个数
        //private void txtOrderQty_Leave(object sender, EventArgs e)
        //{
        //    double createQty = double.Parse(this.txtCreateQTY.Text);
        //    if (!this.cb_pack.Checked)
        //    {
        //        //计算卷盘数量
        //        int reelCount = 0;
        //        double reel = Double.Parse(this.txtReelQTY.Text);
        //        // double a=order%reel;
        //        if (createQty % reel != 0)
        //        {
        //            reelCount = (int)(createQty / reel) + 1;
        //        }
        //        else
        //        {
        //            reelCount = (int)(createQty / reel);
        //        }
        //        this.txtReel.Text = reelCount.ToString();
        //    }
        //    int boxCount = 0;
        //    if (!this.cb_reel.Checked)
        //    {
        //        //计算内盒数量
        //        boxCount = 0;
        //        double box = Double.Parse(this.txtBoxQTY.Text);
        //        //double b = order%box;
        //        if (createQty % box != 0)
        //        {
        //            boxCount = (int)(createQty / box) + 1;
        //        }
        //        else
        //        {
        //            boxCount = (int)(createQty / box);
        //        }
        //    }
        //    this.txtBox.Text = boxCount.ToString();
        //}

        private void btnCreateAndPrint_Click(object sender, EventArgs e)
        {
            btnCreate_Click(sender, e);
            string messages = null;
            //打印标签
            PrintLabels(this.txtKey.Text.Trim(), ref  messages);
            ClearGroupBoxText();
            this.btnCreate.Enabled = false;
            this.btnCreateAndPrint.Enabled = false;
        }

    }
}
