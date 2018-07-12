using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dao;
using Entity;

namespace DaoImpl
{
    public class ExecProcedureDaoImpl : IExecProcedureDao
    {
        public long ExecPrSaveSerialNumber(System.Data.SqlClient.SqlParameter[] parameters)
        {
            using (ERP2008Entities erp2008 =new ERP2008Entities())
            {
                SqlParameter parameter = new SqlParameter("@oldNumber", SqlDbType.BigInt);
                parameter.Direction = ParameterDirection.Output;
                erp2008.Database.ExecuteSqlCommand("EXEC Pr_SaveSerialNumber @clientCode,@number,@oldNumber output", parameters[0], parameters[1], parameter);
                return (long)parameter.Value;
            }
        }

        public long ExecPrSaveSerialNumber(string clientCode, int number)
        {
            //using (ERP2008Entities erp2008 = new ERP2008Entities())
            //{
            //    SqlParameter oldNumber=new SqlParameter("@oldNumber", typeof(int));
            //    erp2008.Pr_SaveSerialNumber(clientCode, number, oldNumber);
            //    return  in
            //}
            return 0;

        }
    }
}
