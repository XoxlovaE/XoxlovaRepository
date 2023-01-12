using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_6
{
    public interface IEntry<T>
    {
       public T Id { get; set; }
    }
}
