using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.LabelsClass
{
   public class BaseLabel
   {
       private string _code;
       private string _type;
       private string _po;
       private string _pn;
       private string _qty;
       private string _date;
       private string _pc; //流程卡
       private string _dc;//批号
       private string _remark;
       private string _rmk;
       private string _order;
       private string _package;
       private int _labelTemplateId;
       private int _createReelQty;
       private int _createBoxQty;
       private int _createMaxBoxQty;

       public string Order
       {
           get { return _order; }
           set { _order = value; }
       }

       public string Rmk
       {
           get { return _rmk; }
           set { _rmk = value; }
       }

       public string Code
       {
           get { return _code; }
           set { _code = value; }
       }

       public string Remark
       {
           get { return _remark; }
           set { _remark = value; }
       }

       public string Dc
       {
           get { return _dc; }
           set { _dc = value; }
       }

       public string Pc
       {
           get { return _pc; }
           set { _pc = value; }
       }

       public string Date
       {
           get { return _date; }
           set { _date = value; }
       }

       public string Qty
       {
           get { return _qty; }
           set { _qty = value; }
       }

       public string Pn
       {
           get { return _pn; }
           set { _pn = value; }
       }

       public string Po
       {
           get { return _po; }
           set { _po = value; }
       }

       public string Type1
       {
           get { return _type; }
           set { _type = value; }
       }

       public int CreateReelQty
       {
           get { return _createReelQty; }
           set { _createReelQty = value; }
       }

       public int CreateBoxQty
       {
           get { return _createBoxQty; }
           set { _createBoxQty = value; }
       }

       public int CreateMaxBoxQty
       {
           get { return _createMaxBoxQty; }
           set { _createMaxBoxQty = value; }
       }

       public int LabelTemplateId
       {
           get { return _labelTemplateId; }
           set { _labelTemplateId = value; }
       }

       public string Package
       {
           get { return _package; }
           set { _package = value; }
       }
   }
}
