using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
   public interface ICustomUtilityDao
   {
       DateTime GetServerDateTime();
   }
}
