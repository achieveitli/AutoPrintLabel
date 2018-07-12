using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Entity;

namespace DaoImpl
{
    public class ClientFreeNameDaoImpl : IClientFreeNameDao
    {
        public t_StAndClient_compaTable FindAndClientCompaTableByObject(t_StAndClient_compaTable compaTable)
        {
            using (ERP2008Entities erp2008 = new ERP2008Entities())
            {
                t_StAndClient_compaTable tStAndClientCompaTable = null;
                if (compaTable != null)
                {
                    if (compaTable.Client_PN != null && compaTable.Client_cCusCode != null & compaTable.St_Type != null)
                    {
                        try
                        {
                            tStAndClientCompaTable = (from i in erp2008.t_StAndClient_compaTable where i.Client_PN == compaTable.Client_PN && i.Client_cCusCode == compaTable.Client_cCusCode && i.St_Type == compaTable.St_Type select i
                           ).SingleOrDefault();
                            return tStAndClientCompaTable;
                        }
                        catch (Exception)
                        {

                            return tStAndClientCompaTable;
                        }

                    }
                    //if (compaTable.Client_PN != null)
                    //{
                    //    tStAndClientCompaTable = (from i in erp2008.t_StAndClient_compaTable where i.Client_PN == compaTable.Client_PN select i
                    //        ).SingleOrDefault();
                    //}
                }
                return tStAndClientCompaTable;
            }
        }
    }
}
