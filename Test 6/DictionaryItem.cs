using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_6
{
    public class DictionaryItem<T> : Entry<T>
    {
        public string Name { get; set; }
        public T Id { get; set; }
        public DictionaryItem(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }    
}
