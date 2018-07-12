using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Dao
{
    public interface ITLabelsDao
    {
        int InsertLabel(t_labels label);
        int ModifyLabel(t_labels label);
        int DeleteLabel(t_labels label);
        int InsertLabel(List<t_labels> lists);
        List<t_labels> FindLabelsesByCode(string code);

        int FindOrderSumQty(string orderCode,string typeCode);

        List<t_labels> FindLabelsesByOrderCodeTypeCode(string orderCode, string typeCode);

    }
}
