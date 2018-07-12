using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Entity;

namespace DaoImpl
{
    public class OpenCardPackDaoImpl : IOpenCardPackDao
    {
        public Entity.t_opencardpack FindOpencardpackByCode(Entity.t_opencardpack opencardpack)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                t_opencardpack card = new t_opencardpack();
                card =
                    (from opencard in erp2008.t_opencardpack
                     //join b in erp2008.b_Inventory on opencard.FProductNo equals b.cInvCode
                     //join sod in erp2008.SO_SODetails on opencard.cSOCode equals sod.cSOCode
                     //join som in erp2008.SO_SOMain on opencard.cSOCode equals  som.cSOCode
                     where opencard.Fbarcode == opencardpack.Fbarcode
                     select opencard).SingleOrDefault();
                return card;
            }
        }

        public t_opencardpack FindOpencardpackByCode(string code)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                t_opencardpack card = new t_opencardpack();
                card =
                    (from opencard in erp2008.t_opencardpack
                     where opencard.Fbarcode == code
                     select opencard).SingleOrDefault();
                return card;
            }
        }
    }
}
