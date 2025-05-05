using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Utils
{
    class GenerateUUID
    {
        public static string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
