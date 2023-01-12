using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Test_8
{
    public interface IDbContextFactory
    {
         DbContext Create();
    }
}