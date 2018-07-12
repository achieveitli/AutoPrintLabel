using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Entity;

namespace Bll
{
     public interface IPrintLabelsBll
    {
        List<t_labels> FindLabelsesByCode(string  code);


         int PrintLabel(List<t_labels> labels, ref string message);

         int PrintLabel(string code, ref string message);
    }
}
