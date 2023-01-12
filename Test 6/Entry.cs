using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_6
{
    public class Entry<T> : IEntry<T>
    {
       public T Id { get; set; }      
    }
}
