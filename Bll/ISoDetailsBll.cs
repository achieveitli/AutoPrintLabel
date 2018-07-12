using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Bll
{
    public interface ISoDetailsBll
    {
         SO_SODetails FindSoDetailsBySoDetails(SO_SODetails soDetails);
    }
}
