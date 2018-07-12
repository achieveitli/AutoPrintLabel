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
    public class A0022BllImpl : ICreateClientRequireBll
    {
        public A0022BllImpl()
        {

        }
        public A0022BllImpl(t_labels label)
        {
            CreateClientRequire(label);
        }
        public void CreateClientRequire(t_labels label)
        {
            CreateClientRequireOne(label);
            CreateClientRequireTwo(label);
            CreateClientRequireThree(label);
        }
        /// <summary>
        /// 3位流水号
        /// </summary>
        /// <param name="label">t_labels 标签对象</param>
        public void CreateClientRequireOne(t_labels label)
        {
            string serialNumber = label.serialNumber.ToString();
            serialNumber = serialNumber.PadLeft(3, Convert.ToChar("0"));
            label.ClientRequireOne = serialNumber;
        }
        /// <summary>
        /// 年周yyWeek
        /// </summary>
        /// <param name="label">t_labels 标签对象</param>
        public void CreateClientRequireTwo(t_labels label)
        {
            label.ClientRequireTwo = CustomFormatDate.GetyyWeek(label.createDate);
        }

        public void CreateClientRequireThree(t_labels label)
        {
            ISoMainDao dao = new SoMainDaoImpl();
            SO_SOMain soMain = dao.FindSoMainByCsoCode(label.orderCode);
            label.ClientRequireThree = soMain.cMemo.Contains("一电") ? "80001" : "80002";
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
