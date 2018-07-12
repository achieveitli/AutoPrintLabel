using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Entity;

namespace DaoImpl
{
    public class SoMainDaoImpl : ISoMainDao
    {
        public Entity.SO_SOMain FindSoMainBySoMain(Entity.SO_SOMain soMain)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                SO_SOMain so = null;
                so =
                    (from main in erp2008.SO_SOMain where main.cSOCode == soMain.cSOCode select main).SingleOrDefault();
                return soMain;

            }
        }

        public Entity.SO_SOMain FindSoMainByCsoCode(string csoCode)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                SO_SOMain soMain = null;
                soMain =
                    (from main in erp2008.SO_SOMain where main.cSOCode == csoCode select main).SingleOrDefault();
                return soMain;
            }
        }
    }
}
