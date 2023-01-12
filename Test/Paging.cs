using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    internal class Paging : IPaging
    {
        public int Skip {get;set;}
        public int Take { get; set; }
    }

    internal class CorrectPaging
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
