using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Utils
{    public class GenerateUUID
    {
        public static string GenerateUniqueId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
