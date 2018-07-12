using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Bll
{
    public interface IClientRequireFactoryBll
    {
        t_labels InsertClientRequire(t_labels label, string labelTemplateName);
    }
}
