
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Test_7;
using Test1;


using var efContext = new EfContext();

IQueryable<Car> carsQuery = efContext.Set<Car>();
var paging = new Paging { Skip=3, Take=5};
var elements=carsQuery.PageBy(paging);
