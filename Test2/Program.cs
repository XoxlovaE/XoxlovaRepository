using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using Test2;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

List<EmployeeDto> GetEmployees()
{
    var dbContext = new StaffDbContext();

    var positions = dbContext.Positions;
    var employees = dbContext.Employees;

    var employeesDto = positions.Join(employees,
     p => p.Id,
     e => e.PositionId, 
     (p, e) => new EmployeeDto { Id = e.Id, PositionName = p.Name }).ToList();

    return employeesDto;
}
