using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Bll;
using Entity;

namespace BllImpl.Labels
{
    public class TPVBllImpl : ICreateClientRequireBll
    {
        public TPVBllImpl()
        {

        }
        public TPVBllImpl(t_labels label)
        {
            CreateClientRequire(label);
        }
        //供应商代码
        private readonly string _vendorCode = "3728901";

        public void CreateClientRequire(t_labels label)
        {
            CreateClientRequireThree(label);
            CreateClientRequireTwo(label);
            CreateClientRequireOne(label);
        }

        /// <summary>
        /// 客户要求的料号 字符长度必须35
        /// </summary>
        /// <param name="label">标签对象</param>
        public void CreateClientRequireOne(t_labels label)
        {
            string pn = label.pn;
            string flowCard = label.flowCard.Substring(0, label.flowCard.IndexOf(Convert.ToChar(" ")));
            string custom = label.ClientRequireThree + _vendorCode + flowCard.Substring(flowCard.Length - 5);
            int count = 35 - pn.Length;
            custom = custom.PadLeft(count, Convert.ToChar(" "));
            label.ClientRequireOne = pn + custom;
        }

        /// <summary>
        /// 水流号
        /// </summary>
        /// <param name="label">标签对象</param>
        public void CreateClientRequireTwo(t_labels label)
        {
            string serialNumber = label.serialNumber.ToString();
            serialNumber = serialNumber.PadLeft(10, Convert.ToChar("0"));
            label.ClientRequireTwo = serialNumber;
        }

        /// <summary>
        /// 年周 yyWeek
        /// </summary>
        /// <param name="label">标签对象</param>
        public void CreateClientRequireThree(t_labels label)
        {
            DateTime date = Convert.ToDateTime(label.createDate);
            //DateTime the_Date = new DateTime(date.Year, 1, 1);//本年的第一天
            //TimeSpan tt = the_Date.AddYears(1) - the_Date;//求出本年有几天
            //int zhouShu=tt.Days / 7 + 1; //因为年只有366天和365天除以7有余数所以始终需要加一周
            //label.ClientRequireThree = zhouShu.ToString();
            GregorianCalendar gc = new GregorianCalendar();
            int weekOfYear = gc.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            label.ClientRequireThree = date.Year.ToString().Substring(2) + weekOfYear;
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
