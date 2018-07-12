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
    public class F4005BllImpl : ICreateClientRequireBll
    {
        //供应商代码
        private readonly string _vendorCode = "2003834";
        private ISoDetailsDao _soDetailsDao = null;
        private IOpenCardPackDao _openCardPack = null;

        public void CreateClientRequire(t_labels label)
        {
            label.vendorCode = _vendorCode;
            CreateClientRequireOne(label);
            CreateClientRequireTwo(label);
        }
        /// <summary>
        /// A+2003834(供应商代码)+yyyyMMdd(日期)+00001(5位流水号)
        /// </summary>
        /// <param name="label">标签对象</param>
        public void CreateClientRequireOne(t_labels label)
        {
            //A+2003834(供应商代码)+yyyyMMdd(日期)+00001(5位流水号)
            string require = "A" + _vendorCode;
            string date=CustomFormatDate.GetyyyyMMdd(label.createDate);
            date=date.Substring(2);
            //int temp = 5-label.serialNumber.ToString().Length;
            string serialNumber = label.serialNumber.ToString();
            serialNumber = serialNumber.PadLeft(5, Convert.ToChar("0"));
            require = require + date + serialNumber;
            label.ClientRequireOne = require;
        }

        /// <summary>
        /// PO+订单明细项目号
        /// </summary>
        /// <param name="label">标签对象</param>
        public void CreateClientRequireTwo(t_labels label)
        {
            //PO+订单明细项目号
            string require = null;
            string xinagMuHao = null;
            _soDetailsDao = new SoDetailsDaoImpl();
            _openCardPack = new OpenCardPackDaoImpl();
            var fsaId = _openCardPack.FindOpencardpackByCode(label.code).FsaID;
            if (fsaId != null)
            {
                int sodetailsId = (int)fsaId;
                SO_SODetails soDetail = _soDetailsDao.FindSoDetailsById(sodetailsId);
                xinagMuHao = soDetail.cFree3;
            }
            require = label.po +"#"+ xinagMuHao;
            label.ClientRequireTwo=require;
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
