using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using Bll;
using Dao;
using DaoImpl;
using Entity;
using Utility;

namespace BllImpl
{
    public class FrmCreatelabelsBllImpl : IFrmCreateLabelsBll
    {
        private ISaPackDao iSaPackDao = null;
        private IOpenCardPackBll openCardPackBll = null;
        private ISoMainBll soMainBll = null;
        private IExecProcedureDao execProcedureDao = null;
        private IOpenCardPackDao openCardPackDao = null;
        private ITLabelsDao tLabelsDao = null;
        private ILabelTemplateDao labelTemplateDao = null;
        private IClientRequireFactoryBll clientRequireFactoryBll = null;
        private ISoDetailsDao soDetailsDao = null;
        private ICustomUtilityDao customUtilityDao = null;
        public FrmCreatelabelsBllImpl()
        {
            iSaPackDao = new SaPackDaoImpl();
            openCardPackBll = new OpenCardPackBllImpl();
            soMainBll = new SoMainBllImpl();
            execProcedureDao = new ExecProcedureDaoImpl();
            openCardPackDao = new OpenCardPackDaoImpl();
            tLabelsDao = new LabelsDaoImpl();
            labelTemplateDao = new LabelTemplateDaoImpl();
            clientRequireFactoryBll = new ClientRequireFactoryBllImpl();
            soDetailsDao = new SoDetailsDaoImpl();
            customUtilityDao = new CustomUtilityDaoImpl();
        }

        public Entity.SA_Packs FindSaPacksBySaPackCode(string saPackCode)
        {
            SA_Packs saPacks = iSaPackDao.FinSaPacksBysaCode(saPackCode);
            return saPacks;
        }

        //没用了
        public int InsertLabel(t_labels label, int createQty, int boxQty, int reelQty, int labelQty)
        {
            t_opencardpack opencardpack = openCardPackDao.FindOpencardpackByCode(label.code);
            if (opencardpack != null)
            {
                //还是要返回一个数量
                long oldNumber = execProcedureDao.ExecPrSaveSerialNumber(label.clientCode.ToUpper().Trim(), labelQty);
                label.typeCode = opencardpack.FProductNo;
                while (createQty > 0)
                {
                    label.qty = reelQty;
                    label.serialNumber = oldNumber;
                    tLabelsDao.InsertLabel(label);
                    createQty = createQty - reelQty;
                }
                while (createQty > 0)
                {
                    label.qty = boxQty;
                    tLabelsDao.InsertLabel(label);
                    createQty = createQty - boxQty;
                }
            }
            return 0;
        }


        /// <summary>
        ///  这里没事务保存会错的
        /// </summary>
        /// <param name="label"></param>
        /// <param name="createQty"></param>
        /// <param name="boxQty"></param>
        /// <param name="reelQty"></param>
        /// <param name="box"></param>
        /// <param name="reel"></param>
        /// <returns></returns>
        /* public int InsertLabel(t_labels label, int createQty, int boxQty, int reelQty, int box, int reel)
         {
             int result = 0;
             t_opencardpack opencardpack = openCardPackDao.FindOpencardpackByCode(label.code);
             if (opencardpack != null)
             {
                 //还是要返回一个数量
                 //int oldNumber = execProcedureDao.ExecPrSaveSerialNumber(label.clientCode.ToUpper().Trim(), box+reel);
                 SqlParameter[] param=new SqlParameter[]
                 {
                     new SqlParameter("@clientCode",opencardpack.cCusCode), 
                     new SqlParameter("@number",box+reel)
                 };
                 int oldNumber = execProcedureDao.ExecPrSaveSerialNumber(param);
                 label.typeCode = opencardpack.FProductNo;
                 for (int i = 0; i < reel; i++)
                 {
                     label.qty = reelQty.ToString();
                     label.serialNumber = oldNumber;
                     label.workOrder = opencardpack.Fwono;
                     //检查重要是否为空
                     int objectNull =ObjectIsNull(label);
                     if (objectNull<=0)
                     {
                         return 0;
                     }
                     result=tLabelsDao.InsertLabel(label);
                     if (result == 0)
                     {
                         break;
                     }
                     oldNumber++;
                 }
                 for (int i = 0; i < box; i++)
                 {
                     label.qty = boxQty.ToString();
                     label.serialNumber = oldNumber;
                     result=tLabelsDao.InsertLabel(label);
                     if (result == 0)
                     {
                         break;
                     }
                     oldNumber++;
                 }
             }
             return result;
         }*/
        /// <summary>
        /// 添加标签信息
        /// </summary>
        /// <param name="label">标签对象</param>
        /// <param name="createQty">生成的总数</param>
        /// <param name="boxQty">盒子数量</param>
        /// <param name="reelQty">卷盘数量</param>
        /// <param name="box">盒子标签数量</param>
        /// <param name="reel">卷盘标签数量</param>
        /// <returns></returns>
        public int InsertLabel(t_labels label, int createQty, int boxQty, int reelQty, int box, int reel, Boolean isBoxPack)
        {
            List<t_labels> labels = new List<t_labels>();
            int result = 0;
            t_opencardpack opencardpack = openCardPackDao.FindOpencardpackByCode(label.code);
            if (opencardpack != null)
            {
                string uidCode = null;
                if (label.labelTemplateAddressId != 235)
                {
                    uidCode = label.clientCode.Trim();
                    string[] tpv = new[] { "T4003", "T4011", "T4017", "T4021", "T4022", "T4027", "T4008", "T4012", "T4016", "T4023" };
                    if (tpv.Contains(uidCode))
                    {
                        uidCode = "TPV";
                    }
                }
                else
                {
                    uidCode = "STANDARD";
                }
                SqlParameter[] param = new SqlParameter[]
               {
                   new SqlParameter("@clientCode",uidCode), 
                   new SqlParameter("@number",box+reel)
               };
                //通过存储过程获取流水号
                long oldNumber = execProcedureDao.ExecPrSaveSerialNumber(param);
                //label.typeCode = opencardpack.FProductNo;
                label.workOrder = opencardpack.Fwono;
                //获取服务器时间
                label.createDate = customUtilityDao.GetServerDateTime().ToString("yyyy-MM-dd HH:mm:ss");
                //最小包装非内盒
                if (!isBoxPack)
                {
                    int tempReelQty = createQty;
                    for (int i = 0; i < reel; i++)
                    {
                        t_labels newLabes = FanShe.Mapper<t_labels, t_labels>(label);
                        if (tempReelQty > reelQty)
                        {
                            newLabes.qty = reelQty;
                        }
                        else
                        {
                            newLabes.qty = tempReelQty;
                        }
                        tempReelQty = tempReelQty - reelQty;
                        newLabes.serialNumber = oldNumber;
                        newLabes.UID = CreateUID(newLabes);
                        newLabes.packType = 1;    //1为卷盘包装类型 2为内盒包装类型 3为外箱包装类型

                        //添加客户特殊要求
                        Label_template template = labelTemplateDao.FindLabelTemplatesById(label.labelTemplateAddressId);
                        string templateName = template.Label_describe.Trim().ToUpper();
                        //newLabes引用类型返回和不返回一样，所以这里调用一下那标签对象了
                        clientRequireFactoryBll.InsertClientRequire(newLabes, templateName);

                        //检查重要属性是否为空
                        int objectNull = ObjectIsNull(newLabes);
                        if (objectNull <= 0)
                        {
                            return 0;
                        }
                        labels.Add(newLabes); //执行添加标签信息
                        oldNumber++;
                    }
                }
                int tempBoxQty = createQty;
                for (int i = 0; i < box; i++)
                {
                    t_labels newLabes = FanShe.Mapper<t_labels, t_labels>(label);
                    if (tempBoxQty > boxQty)
                    {
                        newLabes.qty = boxQty;
                    }
                    else
                    {
                        newLabes.qty = tempBoxQty;
                    }
                    tempBoxQty = tempBoxQty - boxQty;
                    newLabes.serialNumber = oldNumber;
                    newLabes.UID = CreateUID(newLabes);
                    newLabes.packType = 2;
                    Label_template template = labelTemplateDao.FindLabelTemplatesById(label.labelTemplateAddressId);
                    string templateName = template.Label_describe.Trim().ToUpper();
                    clientRequireFactoryBll.InsertClientRequire(newLabes, templateName);
                    //检查重要属性是否为空
                    int objectNull = ObjectIsNull(newLabes);
                    if (objectNull <= 0)
                    {
                        return 0;
                    }
                    labels.Add(newLabes);
                    oldNumber++;
                }
                //保存前再次确认生成的标签数量与前台计算的标签数量是否一致才保存
                result = labels.Count == (box + reel) ? tLabelsDao.InsertLabel(labels) : 0;
            }
            return result;
        }
        /// <summary>
        /// 年月日流水号
        /// </summary>
        /// <param name="newLabes">标签对象</param>
        /// <returns></returns>
        private string CreateUID(t_labels newLabes)
        {
            if (newLabes == null)
            {
                return "";
            }
            DateTime date = Convert.ToDateTime(newLabes.createDate);
            string yy = date.Year.ToString().Substring(2, 2);
            string dd = date.Day.ToString().Trim();
            string mm = date.Month.ToString().Trim();
            if (dd.Length == 1)
            {
                dd = "0" + dd;
            }
            if (mm.Length == 1)
            {
                mm = "0" + mm;
            }
            string uid = yy + mm + dd + newLabes.serialNumber;
            return uid;
        }

        public void ExecProcedure(System.Data.SqlClient.SqlParameter[] parameters)
        {
            execProcedureDao.ExecPrSaveSerialNumber(parameters);
        }

        public void ExecProcedure(string clientCode, int number)
        {
            execProcedureDao.ExecPrSaveSerialNumber(clientCode, number);
        }

        public List<t_labels> FindLabelsesByCod(string code)
        {
            return tLabelsDao.FindLabelsesByCode(code);
        }


        public Label_template FindLabelTemplateById(int id)
        {
            return labelTemplateDao.FindLabelTemplatesById(id);
        }

        /// <summary>
        /// 验证订单数量
        /// </summary>
        /// <param name="orderCode">订单号</param>
        /// <param name="typeCode">产品编码</param>
        /// <param name="createQty">生成数量</param>
        /// <returns></returns>
        public Boolean VerifyOrderQty(string orderCode, string typeCode, int createQty)
        {
            double detailSum = soDetailsDao.FindSoDetailsQtyByCsoAndCinvstd(orderCode, typeCode);
            List<t_labels> labels = tLabelsDao.FindLabelsesByOrderCodeTypeCode(orderCode, typeCode);
            if (labels==null)
            {
                return true;
            }
            Boolean box = false, reel = false;
            foreach (t_labels label in labels)
            {
                if (label.packType == 1)
                {
                    reel = true;
                }
                else if (label.packType == 2)
                {
                    box = true;
                }
            }
            int labelSum = 0;
            if (box && reel)
            {
                labelSum = (tLabelsDao.FindOrderSumQty(orderCode, typeCode)) / 2;
            }
            else if (box || reel)
            {
                labelSum = tLabelsDao.FindOrderSumQty(orderCode, typeCode);
            }
            double templSum = createQty + labelSum;
            if (detailSum == templSum || detailSum > templSum)
            {
                return true;
            }
            return false;
        }

        public SO_SODetails FindSoDetailsById(int id)
        {
            return soDetailsDao.FindSoDetailsById(id);
        }


        /// <summary>
        /// 通过反射检查重要的属性值不为空
        /// </summary>
        /// <param name="label">标签对象</param>
        /// <returns>int</returns>
        private int ObjectIsNull(t_labels label)
        {
            Type type = label.GetType();
            foreach (PropertyInfo pi in type.GetProperties())
            {
                if (!(pi.Name.Contains("ClientRequireOne") || pi.Name.Contains("ClientRequireTwo") || pi.Name.Contains("ClientRequireThree") || pi.Name.Contains("ClientRequireFour") || pi.Name.Contains("ClientRequireFive") || pi.Name.Contains("vendorCode") || pi.Name.Contains("po") || pi.Name.Contains("pn") || pi.Name.Contains("remark")))
                {
                    try
                    {
                        string i = pi.GetValue(label, null).ToString();
                        if (string.IsNullOrEmpty(i))
                        {
                            return 0;
                        }
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }




    }
}
