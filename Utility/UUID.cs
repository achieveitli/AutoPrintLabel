using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public static class UUID
    {
        public static string GetUUID()
        {
            string uuid = System.Guid.NewGuid().ToString().ToUpper().Replace("-", "");
            return uuid;
        }
    }
}
