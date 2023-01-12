using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    [Table("position")]
    internal class Position
    {
        [Column("id")]
        public int Id ;

        [Column("type")]
        public string Type;
          
        [Column("user_id")]
        public Guid UserId;

        [Column("name")]
        public string Name;
    }
}
