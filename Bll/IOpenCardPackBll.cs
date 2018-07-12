using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Bll
{
   public interface IOpenCardPackBll
   {
       t_opencardpack FindOpencardpackByCode(t_opencardpack opencardpack);
   }
}
