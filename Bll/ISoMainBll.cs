using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Bll
{
    public interface ISoMainBll
    {
         SO_SOMain FindSoMainByCsoCode(string csoCode);

         SO_SOMain FindSoMainBySoMain(SO_SOMain somain);

    }
}
