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

namespace Manages
{
    public partial class FrmPrintLabels : Form
    {
        private static FrmPrintLabels frmSingle = null;
        private IPrintLabelsBll printLabelsBll = null;
        private FrmPrintLabels()
        {
            InitializeComponent();
            printLabelsBll=new PrintLabelsBllImpl();
        }

        public static FrmPrintLabels getFrmPrintLabelsSingle()
        {
            if (frmSingle == null)
            {
                frmSingle=new FrmPrintLabels();
            }
            return frmSingle;
        }

        private void FrmPrintLabels_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmPrintLabels_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSingle = null;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.dgvInfo.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            this.dgvInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;
            this.dgvInfo.DataSource = printLabelsBll.FindLabelsesByCode(this.txtCode.Text.Trim());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string message=null;
            int result=printLabelsBll.PrintLabel(this.txtCode.Text.Trim(),ref message);
            if (result==0)
            {
                MessageBox.Show(@"打印失败！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (message!=null)
            {
                MessageBox.Show(message, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvInfo.CurrentRow.Index;
                this.dgvInfo.Rows[e.RowIndex].Selected = true;
                if (Convert.ToBoolean(dgvInfo.Rows[index].Cells[0].Value))
                {
                    dgvInfo.Rows[index].Cells[0].Value = false;
                }
                else
                {
                    dgvInfo.Rows[index].Cells[0].Value = true;
                    //其他的都是false
                    for (int i = 0; i < dgvInfo.Rows.Count - 1; i++)
                    {
                        if (i != index)
                        {
                            dgvInfo.Rows[i].Cells[0].Value = false;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)//如果单击列表头，全选．
            {
                for (int i = 0; i < this.dgvInfo.RowCount; i++)
                {
                    this.dgvInfo.Rows[i].Cells[0].Value = "true";//如果为true则为选中,false未选中
                }
            }
        }
    }
}
