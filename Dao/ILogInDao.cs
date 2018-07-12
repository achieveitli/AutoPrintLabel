using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using  Entity;
namespace Dao
{
   public interface ILogInDao
    {
        b_User LongIn(b_User user);
    }
}
