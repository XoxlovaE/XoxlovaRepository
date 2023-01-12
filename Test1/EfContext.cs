using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class EfContext:DbContext
    {       
             public DbSet<Car> Cars { get; set; }
    }
}
