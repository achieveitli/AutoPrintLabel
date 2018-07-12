using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Dao
{
    public interface IOpenCardPackDao
    {
        t_opencardpack FindOpencardpackByCode(t_opencardpack opencardpack);

        t_opencardpack FindOpencardpackByCode(string code);
    }
}
