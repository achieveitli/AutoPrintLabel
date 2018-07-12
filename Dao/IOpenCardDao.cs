using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Dao
{
    public interface IOpenCardDao
    {
        t_opencardpack_sf getLabelInfoByCode(string code);
    }
}
