using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll;
using Dao;
using DaoImpl;
using Entity;

namespace BllImpl
{
    public class LogInBllImpl:ILogInBll
    {
        private ILogInDao dao = null;

        public LogInBllImpl()
        {
             dao = new LogInDaoImp();
        }
        public bool Login(b_User user)
        {
            b_User newUser = dao.LongIn(user);
            if (newUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
