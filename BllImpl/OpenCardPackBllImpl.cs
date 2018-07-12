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
   public class OpenCardPackBllImpl : IOpenCardPackBll
    {
        private IOpenCardPackDao dao =null;

        public OpenCardPackBllImpl()
        {
            dao =new OpenCardPackDaoImpl();
        }
        public Entity.t_opencardpack FindOpencardpackByCode(Entity.t_opencardpack opencardpack)
        {
            t_opencardpack newOpencardpack = dao.FindOpencardpackByCode(opencardpack);
            if (newOpencardpack!=null)
            {
                return newOpencardpack;
            }
            else
            {
                return null;
            }
        }
    }
}
