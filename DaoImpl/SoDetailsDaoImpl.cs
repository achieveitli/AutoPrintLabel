using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Entity;

namespace DaoImpl
{
    public class SoDetailsDaoImpl:ISoDetailsDao
    {
        public Entity.SO_SODetails FindSoDetailsBySoDetails(Entity.SO_SODetails soDetails)
        {
            using (ERP2008Entities erp2008 =new ERP2008Entities())
            {
                //有时候客户一个订单下单分几次下一个型号，此处用来提出明细单的说明    18-6-23 lee
                //一般一个订单号多个型号说明应该是一样的，所以直接拿第一个的说明就好了  18-6-23  lee
                SO_SODetails details = null;
                details = (from de in erp2008.SO_SODetails
                    where de.cSOCode == soDetails.cSOCode && de.cInvCode == soDetails.cInvCode
                    select de).ToList()[0];
                return details;
            }
        }

        public List<SO_SODetails> FindSoDetailsByDetailses(SO_SODetails soDetails)
        {
            using (ERP2008Entities erp2008=new ERP2008Entities())
            {
                List<SO_SODetails> details = null;
                details = (from detail in erp2008.SO_SODetails  select detail
                    ).ToList();
                return details;
            }
        }

        public List<SO_SODetails> FindSoDetailsByCsoAndCinvstd(string cSoCode, string cinvstd)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                List<SO_SODetails> details = null;
                details = (from detail in erp2008.SO_SODetails where detail.cSOCode==cSoCode &&  detail.cInvCode==cinvstd  select detail
                    ).ToList();
                return details;
            }
        }

        public double FindSoDetailsQtyByCsoAndCinvstd(string cSoCode, string cinvstd)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                double sum = 0.0;
                var query = (from detail in erp2008.SO_SODetails
                    where detail.cSOCode == cSoCode && detail.cInvCode == cinvstd
                    select detail.iQuantity
                    ).Sum();
                if (query != null)
                    sum =(double) query;
                return sum;
            }
        }

        public SO_SODetails FindSoDetailsById(int id)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                SO_SODetails details = null;
                details = (from de in erp2008.SO_SODetails
                    where de.AutoID == id
                    select de).SingleOrDefault();
                return details;
            }
        }
    }
}
