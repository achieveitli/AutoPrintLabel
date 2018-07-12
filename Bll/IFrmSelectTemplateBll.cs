using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Bll
{
    public interface IFrmSelectTemplateBll
    {
        List<Label_template> FindLabelTemplateByClientCode(string clientCode);
    }
}
