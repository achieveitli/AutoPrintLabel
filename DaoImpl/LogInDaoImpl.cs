using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using Dao;
using Entity;
using Utility;

namespace DaoImpl
{
    public class LogInDaoImp:ILogInDao
    {
       
        public b_User LongIn(b_User user)
        {

            using (ERP2008Entities erp2008=new ERP2008Entities())
            {
                CustomMD5  custom=new CustomMD5();
                string pwd = custom.getpwd(user.cPassword);
                b_User query = (from u in erp2008.b_User where u.cUser_Id == user.cUser_Id && u.cPassword == pwd select u).SingleOrDefault();
                if (query != null)
                {
                    return query;
                    
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
