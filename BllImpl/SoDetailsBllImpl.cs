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
   public class SoDetailsBllImpl:ISoDetailsBll
   {
       private ISoDetailsDao dao = null;

       public SoDetailsBllImpl()
       {
           dao=new SoDetailsDaoImpl();
       }

        public Entity.SO_SODetails FindSoDetailsBySoDetails(Entity.SO_SODetails soDetails)
        {
            SO_SODetails details = null;
            details = dao.FindSoDetailsBySoDetails(soDetails);
            return details;
        }
    }
}
