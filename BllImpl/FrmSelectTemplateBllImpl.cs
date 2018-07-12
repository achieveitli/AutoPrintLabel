using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll;
using Dao;
using DaoImpl;

namespace BllImpl
{
   public class FrmSelectTemplateBllImpl:IFrmSelectTemplateBll
   {
       private ILabelTemplateDao labelTemplateDao = null;
       public FrmSelectTemplateBllImpl()
       {
           labelTemplateDao=new LabelTemplateDaoImpl();
       }
        public List<Entity.Label_template> FindLabelTemplateByClientCode(string clientCode)
        {
           return labelTemplateDao.FindLabelTemplatesByClientCode(clientCode);
        }
    }
}
