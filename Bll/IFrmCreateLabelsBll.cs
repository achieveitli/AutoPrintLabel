using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Entity;

namespace Bll
{
    public interface IFrmCreateLabelsBll
    {

         SA_Packs FindSaPacksBySaPackCode(string saPackCode);


        int InsertLabel(t_labels label ,int createQty,int boxQty,int reelQty,int labelQty);

        int InsertLabel(t_labels label, int createQty, int boxQty, int reelQty, int box,int reel,Boolean isBoxPack);

        void ExecProcedure(SqlParameter[] parameters);

        void ExecProcedure(string clientCode, int number);

        List<t_labels> FindLabelsesByCod(string code);

        Label_template FindLabelTemplateById(int id);

        Boolean VerifyOrderQty(string orderCode,string typeCode,int createQty);

        SO_SODetails FindSoDetailsById(int id);
    }
}
