using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
namespace Utility
{
    public static class LabelFactory
    {
        public static BaseLabel getObjectLabel(string labelName)
        {
            BaseLabel label=null;
            switch (labelName.ToUpper())
            {
                case "F4005":
                     
                    break;
                default:
                    break;
            }
            return label;
        }


        public static t_labels InsertClientRequire(t_labels label,string labelTemplateName)
        {
            t_labels nLabel = null;
            switch (labelTemplateName.ToUpper().Trim())
            {
                case "H4028专用标签":
                   
                    break;
                default:
                    break;
            }
            return label;
        }








    }
}
