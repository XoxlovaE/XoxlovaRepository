using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_4
{
    public class EnumItemDto   // : IEquatable<EnumItemDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Если реализовать метод Equals, Ссылочный тип будет сравниваться по нижележащей логике
        //public bool Equals(EnumItemDto? other)
        //{
        //   if (Id == other.Id && Name == other.Name) return true;
        //   return false;
        //}
    }
}
