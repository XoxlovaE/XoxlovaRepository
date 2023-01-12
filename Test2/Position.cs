using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    [Table("position")]
    internal class Position
    {
        [Column("id")]
        public int Id;
        [Column("name")]
        public string Name;
    }        
}
