using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    [Table("employee")]
    internal class Employee
    {
        [Column("id")]
        public Guid Id;
        [Column("full_name")]
        public string FullName;
        [Column("position_id")]
        public int PositionId;
    }
}
