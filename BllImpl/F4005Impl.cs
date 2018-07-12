using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bll;
using Entity;
using Utility;

namespace BllImpl
{
    public class F4005Impl:IF4005Bll
    {

        private BaseLabel baseLabel;

        F4005Impl() 
        {
            baseLabel = LabelFactory.getObjectLabel("F4005");
        }




    }
}
