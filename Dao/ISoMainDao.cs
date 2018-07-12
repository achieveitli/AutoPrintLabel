using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Dao
{
    public interface ISoMainDao
    {
        SO_SOMain FindSoMainBySoMain(SO_SOMain soMain);
        SO_SOMain FindSoMainByCsoCode(string csoCode);
    }
}
