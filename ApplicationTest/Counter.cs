using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTest
{
    public class Counter
    {
        private static int i = 0;

        public static int increment()
        {
            return i++;
        }
    }
}
