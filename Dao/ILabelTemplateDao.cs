using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Dao
{
   public interface ILabelTemplateDao
   {
       List<Label_template> FindLabelTemplatesByClientCode(string  clientCode);

       Label_template FindLabelTemplatesById(int id);




   }
}
