using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Dao
{
   public  interface ISaPackDao
   {
       SA_Packs FinSaPacksBysaCode(string  saCode);

       SA_Packs FindSaPacksBySaPacks(SA_Packs saPacks);
   }
}
