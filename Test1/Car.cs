using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    [Table("car")]
    public class Car
    {
        [Column("id")]
        public int Id;
        [Column("model_name")]
        public string ModelName;
        [Column("brand_name")]
        public string BrandName;
    }
}
