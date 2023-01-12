using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_9
{
    internal class ListCreator
    {
        public static IEnumerable<int> GetList()
        {
            while (true)
                yield return 1;
        }
    }
}
