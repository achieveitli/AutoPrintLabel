using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Entity;

namespace DaoImpl
{
    public class SaPackDaoImpl :ISaPackDao
    {
        public Entity.SA_Packs FinSaPacksBysaCode(string saCode)
        {
            using (ERP2008Entities erp2008=new ERP2008Entities())
            {
                SA_Packs saPacks = null;
                saPacks = (from saPack in erp2008.SA_Packs where saPack.cPCode==saCode select saPack
                    ).SingleOrDefault();
                return saPacks;
            }
        }

        public Entity.SA_Packs FindSaPacksBySaPacks(Entity.SA_Packs saPacks)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                SA_Packs saPack = null;
                saPack = (from pack in erp2008.SA_Packs where pack.cPCode == saPacks.cPCode select pack
                    ).SingleOrDefault();
                return saPack;
            }
        }
    }
}
