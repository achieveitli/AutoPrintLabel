using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll;
using Entity;
using Utility;

namespace BllImpl.Labels
{
    public class A0024BllImpl : ICreateClientRequireBll
    {
        public A0024BllImpl()
        {

        }

        public A0024BllImpl(t_labels label)
        {
            CreateClientRequire(label);
        }
        public void CreateClientRequire(t_labels label)
        {
            CreateClientRequireOne(label);
            CreateClientRequireTwo(label);
        }

        /// <summary>
        /// 流水号
        /// </summary>
        /// <param name="label">t_labels 标签信息</param>
        public void CreateClientRequireOne(t_labels label)
        {
            string temp = CustomFormatDate.GetyyMMd(label.createDate);
            string serialNumber = label.serialNumber.ToString();
            serialNumber = serialNumber.PadLeft(3, Convert.ToChar("0"));
            temp = temp + serialNumber;
            label.ClientRequireOne = temp;
        }
        /// <summary>
        /// 年周yyweek
        /// </summary>
        /// <param name="label">t_labels 标签信息</param>
        public void CreateClientRequireTwo(t_labels label)
        {
            label.ClientRequireTwo = CustomFormatDate.GetyyWeek(label.createDate);
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
