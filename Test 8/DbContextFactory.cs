using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_8
{
    internal class DbContextFactory :IDbContextFactory
    {
        public DbSet<JobType> JobTypes { get; set; }        

       public DbContext Create()
        {
            throw new NotImplementedException();
        }
    }
}
