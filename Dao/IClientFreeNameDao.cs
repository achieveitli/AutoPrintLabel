using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Entity;

namespace Dao
{
   public  interface IClientFreeNameDao
   {
       t_StAndClient_compaTable FindAndClientCompaTableByObject(t_StAndClient_compaTable compaTable);
   }
}
