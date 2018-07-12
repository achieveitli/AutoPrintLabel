using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll;
using BllImpl.Labels;
using Entity;

namespace BllImpl
{
    public class ClientRequireFactoryBllImpl :IClientRequireFactoryBll
    {
        /// <summary>
        /// 依据模版名称添加客户要求
        /// </summary>
        /// <param name="label">标签对象(一定要传引用对象)</param>
        /// <param name="labelTemplateName">模版名称</param>
        /// <returns>返回标签对象</returns>
        public t_labels InsertClientRequire(t_labels label, string labelTemplateName)
        {
            switch (labelTemplateName.ToUpper().Trim())
            {
                case "H4028专用标签":
                    H4028BllImpl h4028=new H4028BllImpl();
                    h4028.CreateClientRequire(label);
                    break;
                case "F4005专用标签":
                    F4005BllImpl f4005 = new F4005BllImpl();
                    f4005.CreateClientRequire(label);
                    break;
                case "TPV专用标签":
                    TPVBllImpl tpv = new TPVBllImpl(label);
                    break;
                case "A0022专用标签":
                    ICreateClientRequireBll a0022 = new A0022BllImpl(label);
                    break;
                case "A0024专用标签":
                    ICreateClientRequireBll a0024 = new A0024BllImpl(label);
                    break;
                default:
                    label = null;
                    break;
            }
            return label;
        }
    }
}
