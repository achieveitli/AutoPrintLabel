using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Entity;

namespace DaoImpl
{
   public class LabelTemplateDaoImpl:ILabelTemplateDao
    {
        public List<Entity.Label_template> FindLabelTemplatesByClientCode(string clientCode)
        {
            using (ERP2008Entities erp2008=new ERP2008Entities())
            {
                List<Label_template> labelTemplates = null;
                if (string.IsNullOrEmpty(clientCode))
                {
                    labelTemplates = (from labelTemplate in erp2008.Label_template where labelTemplate.cCusCode == "STANDARD" select labelTemplate
                   ).ToList();
                }
                //labelTemplates = (from labelTemplate in erp2008.Label_template  where labelTemplate.cCusCode==clientCode || labelTemplate.cCusCode=="Semtech"   select labelTemplate
                //    ).ToList();
                string[] clientCodes = new string[] { clientCode, "STANDARD" };
                labelTemplates = (from labelTemplate in erp2008.Label_template where clientCodes.Contains(labelTemplate.cCusCode) select labelTemplate
                    ).ToList();
                //labelTemplates = (from labelTemplate in erp2008.Label_template where labelTemplate.cCusCode == clientCode || labelTemplate.cCusCode == "STANDARD" select labelTemplate
                //    ).ToList();
                return labelTemplates;
            }
        }

       public Label_template FindLabelTemplatesById(int id)
       {
           using (ERP2008Entities erp2008 = new ERP2008Entities())
           {
               Label_template labelTemplates = null;
               if (id!=0)
               {
                   labelTemplates =
                       (from labelTemplate in erp2008.Label_template
                           where labelTemplate.Label_NO == id
                           select labelTemplate
                           ).SingleOrDefault();
               }
               return labelTemplates;
           }
       }
    }
}
