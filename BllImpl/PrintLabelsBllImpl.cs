using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Bll;
using Dao;
using DaoImpl;
using Entity;
using Seagull.BarTender.Print;
using Seagull.BarTender.Print.Database;
using Seagull.BarTender.SystemDatabase;

namespace BllImpl
{
    public class PrintLabelsBllImpl : IPrintLabelsBll
    {
        private ITLabelsDao tLabelsDao = null;
        private ILabelTemplateDao labelTemplateDao = null;

        public PrintLabelsBllImpl()
        {
            tLabelsDao = new LabelsDaoImpl();
            labelTemplateDao = new LabelTemplateDaoImpl();
        }

        public List<t_labels> FindLabelsesByCode(string code)
        {
            return tLabelsDao.FindLabelsesByCode(code);
        }

        public int PrintLabel(List<t_labels> labels, ref string message)
        {
            //if (labels.Count != 0)
            //{
            //    Engine engin = new Engine(true);
            //    Label_template template = labelTemplateDao.FindLabelTemplatesById(labels[0].labelTemplateAddressId);
            //    LabelFormatDocument format = engin.Documents.Open(template.Label_Path, template.Print_Cmd);
            //    format.PrintSetup.IdenticalCopiesOfLabel = 1; //默认打印一张
            //    foreach (t_labels lb in labels)
            //    {
            //        foreach (SubString sub in format.SubStrings)
            //        {
            //            var types = lb.GetType();
            //            foreach (PropertyInfo property in types.GetProperties())
            //            {
            //                if (property.Name == sub.Name)
            //                {
            //                    try
            //                    {
            //                        sub.Value = property.GetValue(lb, null).ToString();
            //                    }
            //                    catch (Exception)
            //                    {
            //                        sub.Value = "";
            //                    }
            //                }
            //            }
            //        }
            //        Messages mes;
            //        //Result result = format.Print(template.Label_describe + "-" + template.Label_NO,2000, out mes);
            //        Result result = format.Print(template.Label_describe + "-" + template.Label_NO, out mes);
            //        message = mes[0].Text;
            //    }
            //    format.Close(SaveOptions.DoNotSaveChanges);
            //    engin.Stop(SaveOptions.DoNotSaveChanges);
            //    return 1;
            //}
            //return 0;

            try
            {
                Engine engin = new Engine(true);
                Label_template template = labelTemplateDao.FindLabelTemplatesById(labels[0].labelTemplateAddressId);
                //LabelFormatDocument format = engin.Documents.Open(template.Label_Path, template.Print_Cmd);
                SystemDatabaseConnection conn = new SystemDatabaseConnection();
                conn.Method = SystemDatabaseConnectionMethod.Manual;
                conn.Authentication = SystemDatabaseAuthenticationMethod.SQLServer;
                conn.ServerName = @"192.168.1.201";
                conn.DatabaseName = "ERP2008";
                conn.UserName = "sa";
                conn.Password = "semtech%168";
                conn.Connect();




                string sqlcommand = "SELECT * FROM  dbo.t_labels WHERE code='" + labels[0].code + "'";
                OLEDB oledb = new OLEDB("ERP2008");
                oledb.SQLStatement = sqlcommand;
                LabelFormatDocument format = engin.Documents.Open(template.Label_Path, template.Print_Cmd);
                format.DatabaseConnections.SetDatabaseConnection(oledb);
                format.PrintSetup.IdenticalCopiesOfLabel = 1; //默认打印一张
                //format.Print();
                Messages mes;
                Result result = format.Print(template.Label_describe + "-" + template.Label_NO, 2000, out mes);
                format.Close(SaveOptions.DoNotSaveChanges);
                engin.Stop();
                return 1;
            }
            catch (Exception)
            {

                throw;
                return 0;
            }




        }

        public int PrintLabel(string code, ref string message)
        {
            List<t_labels> labels = tLabelsDao.FindLabelsesByCode(code);
            return PrintLabel(labels, ref message);
        }



        public int PrintLabel(t_labels label, int printcount, int[] ids, ref string message)
        {
            Engine engin = null;
            LabelFormatDocument format = null;
            try
            {
                engin = new Engine(true);
                Label_template template = labelTemplateDao.FindLabelTemplatesById(label.labelTemplateAddressId);
                SystemDatabaseConnection conn = new SystemDatabaseConnection();
                conn.Method = SystemDatabaseConnectionMethod.Manual;
                conn.Authentication = SystemDatabaseAuthenticationMethod.SQLServer;
                conn.ServerName = @"192.168.1.201";
                conn.DatabaseName = "ERP2008";
                conn.UserName = "sa";
                conn.Password = "semtech%168";
                conn.Connect();
                string sqlcommand = null;
                if (ids.Length == 0 || ids == null)
                {
                    sqlcommand = "SELECT * FROM  dbo.t_labels WHERE code='" + label.code + "'";
                }
                else
                {
                    sqlcommand = "SELECT * FROM  t_labels WHERE  autoid IN( ";
                    foreach (int id in ids)
                    {
                        sqlcommand = sqlcommand + id + ",";
                    }
                    sqlcommand = sqlcommand.Substring(0, sqlcommand.Length - 1);
                    sqlcommand = sqlcommand + ")";

                }
                OLEDB oledb = new OLEDB("ERP2008");
                oledb.SQLStatement = sqlcommand;
                format = engin.Documents.Open(template.Label_Path, template.Print_Cmd);
                format.DatabaseConnections.SetDatabaseConnection(oledb);
                format.PrintSetup.IdenticalCopiesOfLabel = printcount; //默认打印一张
                Messages mes;
                Result result = format.Print(template.Label_describe + "-" + template.Label_NO, 10000);
                if (Result.Failure == result)
                {
                    message += result;
                    return 0;
                }
                else if (Result.Success == result)
                {
                    message += result;
                    return 0;
                }

                return 1;
            }
            catch (Exception e)
            {
                message += e.Message;
                return 0;
            }
            finally
            {
                if (format != null) format.Close(SaveOptions.DoNotSaveChanges);
                if (engin != null) engin.Stop();
            }
        }
    }
}
