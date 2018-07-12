using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll;
using Dao;
using DaoImpl;
using Entity;
using Utility;

namespace BllImpl.Labels
{
    public class H4028BllImpl : ICreateClientRequireBll
    {
        //的书科教的的码代商应供商应供
        private readonly string _vendorCode="14756";
        //客户产品称名称名
        private  IClientFreeNameDao clientFreeNameDao=null;
        public H4028BllImpl()
        {
            clientFreeNameDao = new ClientFreeNameDaoImpl();
        }

        public void CreateClientRequire(t_labels label)
        {
            label.vendorCode = _vendorCode;
            CreateClientRequireOne(label);
            CreateClientRequireTwo(label);
        }
        /// <summary>
        /// 箱号条码
        /// </summary>
        /// <param name="label">标签对象</param>
        public void CreateClientRequireOne(t_labels label)
        {
            string cro = null, date = null, serialNumber = null;
            cro = label.packType == 1 || label.packType == 2 ? "SL14756" : "SC14756";
            date = CustomFormatDate.GetyyyyMMdd(label.createDate);
            serialNumber = label.serialNumber.ToString().Trim();
            label.ClientRequireOne= cro + date + serialNumber;
        }

        public void CreateClientRequireTwo(t_labels label)
        {
            t_StAndClient_compaTable tStAndClientCompaTable=new t_StAndClient_compaTable();
            tStAndClientCompaTable.Client_PN = label.pn;
            tStAndClientCompaTable.Client_cCusCode = label.clientCode;
            tStAndClientCompaTable.St_Type = label.type;
            tStAndClientCompaTable = clientFreeNameDao.FindAndClientCompaTableByObject(tStAndClientCompaTable);
            label.ClientRequireTwo = tStAndClientCompaTable.Client_TypeName;
        }

        public void CreateClientRequireThree(t_labels label)
        {
            throw new NotImplementedException();
        }

        public void CreateClientRequireFour(t_labels label)
        {
            throw new NotImplementedException();
        }

        public void CreateClientRequireFive(t_labels label)
        {
            throw new NotImplementedException();
        }
    }
}
