using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Dao
{
    public interface IExecProcedureDao
    {
        long ExecPrSaveSerialNumber(SqlParameter[] parameters);
        long ExecPrSaveSerialNumber(string clientCode,int number);
    }
}
