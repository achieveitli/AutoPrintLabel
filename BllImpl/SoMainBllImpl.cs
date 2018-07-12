using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll;
using Dao;
using DaoImpl;
using Entity;

namespace BllImpl
{
   public class SoMainBllImpl:ISoMainBll
    {
        private  ISoMainDao dao =null;

        public SoMainBllImpl()
        {
            dao = new SoMainDaoImpl();
        }

        public Entity.SO_SOMain FindSoMainByCsoCode(string csoCode)
        {
            SO_SOMain main = null;
            main = dao.FindSoMainByCsoCode(csoCode);
            return main;
        }

        public Entity.SO_SOMain FindSoMainBySoMain(Entity.SO_SOMain somain)
        {
            SO_SOMain main = null;
            main = dao.FindSoMainBySoMain(somain);
            return main;
        }
    }
}
