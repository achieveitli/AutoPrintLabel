using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    interface ILabelUID
    {
        /// <summary>
        /// 获取唯一标识符
        /// </summary>
        /// <returns>string</returns>
        string GetUID();

        /// <summary>
        /// 更新唯一标识符
        /// </summary>
        /// <returns>string</returns>
        string UpdateUID();

        /// <summary>
        /// 计算唯一标识符
        /// </summary>
        /// <returns>string</returns>
        string CountUID();




    }
}
