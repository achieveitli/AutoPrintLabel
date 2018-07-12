using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Entity;

namespace DaoImpl
{
   public class CustomUtilityDaoImpl :ICustomUtilityDao
    {
        public DateTime GetServerDateTime()
        {
            using (ERP2008Entities erp2008=new ERP2008Entities())
            {
                var now = erp2008.Database.SqlQuery<DateTime?>("SELECT GetDate()").First();
                if (now ==null)
                {
                    now = new DateTime(1900, 1, 1, 0, 0, 0);
                }
                return now.Value;
            }
        }
    }
}
