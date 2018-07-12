using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public abstract class BaseLabel
    {
        //条码
        private string _code;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        //客户料号
        private string _pn;
        public string Pn
        {
            get { return _pn; }
            set { _pn = value; }
        }
        //客户订单号
        private string _po;
        public string Po
        {
            get { return _po; }
            set { _po = value; }
        }
        //销售订单号
        private string _cSoCode;
        public string CSoCode
        {
            get { return _cSoCode; }
            set { _cSoCode = value; }
        }
        //出货日期
        private string _dPreDate;
        public string DPreDate
        {
            get { return _dPreDate; }
            set { _dPreDate = value; }
        }
        //产品型号
        private string _cinvstd;
        public string Cinvstd
        {
            get { return _cinvstd; }
            set { _cinvstd = value; }
        }
        //产品规格名称
        private string _cinvname;
        public string Cinvname
        {
            get { return _cinvname; }
            set { _cinvname = value; }
        }
        //产品批号
        private string _batchNo;
        public string BatchNo
        {
            get { return _batchNo; }
            set { _batchNo = value; }
        }
        //产品封装
        private string _zhushen;
        public string Zhushen
        {
            get { return _zhushen; }
            set { _zhushen = value; }
        }

        //流程卡号
        private string _fsn;
        public string Fsn
        {
            get { return _fsn; }
            set { _fsn = value; }
        }
        //放大倍数
        private string _zoom;
        public string Zoom
        {
            get { return _zoom; }
            set { _zoom = value; }
        }
        //脚型
        private string _ffoot;
        public string Ffoot
        {
            get { return _ffoot; }
            set { _ffoot = value; }
        }
        //备注
        private string _fnote;
        public string Fnote
        {
            get { return _fnote; }
            set { _fnote = value; }
        }
        //唯一标识符
        private string _uid;
        public string Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        /// <summary>
        /// 打印日期
        /// </summary>
        private string _printDay;

        public string PrintDay
        {
            //这里要改为服务器时间，不能用当前电脑时间
            get { return DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day; }

        }


        /// <summary>
        /// 处理流水号
        /// </summary>
        /// <param name="serialNumber">上一个流水号</param>
        /// <returns>生成的流水号</returns>
        public abstract string GetSerialNumber(string serialNumber);


    }
}
