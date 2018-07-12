using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Entity;

namespace Dao
{
   public interface ISoDetailsDao
   {
       SO_SODetails FindSoDetailsBySoDetails(SO_SODetails soDetails);

       List<SO_SODetails> FindSoDetailsByDetailses(SO_SODetails soDetails);
       List<SO_SODetails> FindSoDetailsByCsoAndCinvstd(string cSoCode, string cinvstd);
       double FindSoDetailsQtyByCsoAndCinvstd(string cSoCode, string cinvstd);
       SO_SODetails FindSoDetailsById(int id);
   }
}
