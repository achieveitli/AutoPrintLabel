using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Bll;
using BllImpl;
using Entity;

namespace Manages
{
    public delegate string  FindClientCode();

    public delegate void ReturnId(int id);
    public partial class FrmSelectTemplate : Form
    {
        private static FindClientCode _findClientCode;
        private static ReturnId _returnId;
        private static FrmSelectTemplate frmSelectTemplate = null;
        private IFrmSelectTemplateBll frmSelectTemplateBll = null;
        
        private FrmSelectTemplate()
        {
            InitializeComponent();
            frmSelectTemplateBll=new FrmSelectTemplateBllImpl();
        }


        public static FrmSelectTemplate GetSingle(FindClientCode findClientCode,ReturnId returnId)
        {
            _findClientCode = findClientCode;
            _returnId = returnId;
            if (frmSelectTemplate==null)
            {
                frmSelectTemplate=new FrmSelectTemplate();
            }
            return frmSelectTemplate;
        }

        public static FrmSelectTemplate GetSingle(string clientCode)
        {
            if (frmSelectTemplate == null)
            {
                frmSelectTemplate = new FrmSelectTemplate();
            }
            return frmSelectTemplate;
        }

        private void FrmSelectTemplate_Load(object sender, EventArgs e)
        {
            //this.cobTemplate.Items.Clear();
            //string a = _findClientCode();
            List<Label_template> lists = frmSelectTemplateBll.FindLabelTemplateByClientCode(_findClientCode());
            this.cobTemplate.DataSource = lists;
            //this.cobTemplate.DisplayMember = "Label_describe";
            this.cobTemplate.DisplayMember = "cMemo";
            this.cobTemplate.ValueMember = "Label_NO";
            //foreach (Label_template template in lists)
            //{
            //    this.cobTemplate.Items.Add(template.Label_describe);
            //}
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(a, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int  id = (int)this.cobTemplate.SelectedValue;
            _returnId(id);
            //MessageBox.Show(id.ToString(), @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }




    }
}
