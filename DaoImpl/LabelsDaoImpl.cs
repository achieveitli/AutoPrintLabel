using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using Dao;
using Entity;

namespace DaoImpl
{
    public class LabelsDaoImpl : ITLabelsDao
    {
        public int InsertLabel(Entity.t_labels label)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                erp2008.t_labels.Add(label);
                return erp2008.SaveChanges();
            }
        }

        public int ModifyLabel(Entity.t_labels label)
        {
            throw new NotImplementedException();
        }

        public int DeleteLabel(Entity.t_labels label)
        {
            throw new NotImplementedException();
        }

        public int InsertLabel(List<t_labels> lists)
        {
            int result = 0;
            using (var scope = new TransactionScope(TransactionScopeOption.Required))
            {
                using (ERP2008Entities erp2008 = new ERP2008Entities())
                {
                    try
                    {
                        foreach (t_labels labels in lists)
                        {
                            erp2008.t_labels.Add(labels);
                            if (erp2008.SaveChanges() <= 0)
                            {
                                throw new Exception();
                            }
                        }
                        scope.Complete();
                        result = 1;
                    }
                    catch (Exception)
                    {
                        scope.Dispose();
                        result = 0;
                    }
                }
            }
            return result;
        }

        public List<t_labels> FindLabelsesByCode(string code)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                return (from tabel in erp2008.t_labels where tabel.code == code select tabel
                    ).ToList();
            }
        }

        public int FindOrderSumQty(string orderCode, string typeCode)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                int sum = 0;
                try
                {
                    var query =
                    (from labels in erp2008.t_labels
                     where labels.orderCode == orderCode && labels.typeCode == typeCode
                     select labels.qty
                        ).Sum();
                    if (query != null)
                    {
                        sum = (int)query;
                    }
                }
                catch (Exception)
                {
                    sum = 0;
                }
                return sum;
            }
        }

        public List<t_labels> FindLabelsesByOrderCodeTypeCode(string orderCode, string typeCode)
        {
            using (ERP2008Entities erp2008=new ERP2008Entities())
            {
                List<t_labels> labels = null;
                try
                {
                    labels = (from l in erp2008.t_labels where l.orderCode == orderCode && l.typeCode == typeCode select l
                    ).ToList();
                }
                catch (Exception)
                {
                    labels = null;
                }
                
                return labels;
            }
        }
    }
}
