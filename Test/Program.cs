using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using DaoImpl;
using Entity;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOpenCardDao dao = new OpenCardImpl();
            //t_opencardpack_sf info = dao.getLabelInfoByCode("SF1702240301");
            //Console.WriteLine(info.ToString());
            //Console.ReadKey();



            //List<string> lists = new List<string>();
            //for (int i = 0; i <= 3000; i++)
            //{
            //    lists.Add(System.Guid.NewGuid().ToString().ToUpper().Replace("-", ""));
            //    Console.WriteLine("第" + i + "次");  
            //}

            //for (int i = 0; i < lists.Count; i++)
            //{
            //    Console.WriteLine("第"+i+"次");  
            //    for (int j = i; j < lists.Count; j++)
            //    {
            //        if (i==j)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine("-------第" + j + "个");
            //        if (lists[i]==lists[j])
            //        {
            //            Console.WriteLine("!!!!!!!!!!!重复了！！！！" );
            //        }
            //    }
            //}



            //Console.WriteLine(System.Guid.NewGuid().ToString().ToUpper().Replace("-",""));



            Test2 t = new Test2();
            Console.WriteLine(t.getpwd("sterpst"));



            Console.ReadKey();
        }
    }
}
