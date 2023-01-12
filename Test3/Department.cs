using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    [Table("department")]
    internal class Department
    {
        [Column("user_id")]
        public Guid UserId;
        [Column("name")]
        public string Name;
    }
}
