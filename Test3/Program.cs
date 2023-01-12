using Microsoft.EntityFrameworkCore;
using Test3;

var userId = Guid.NewGuid();

// dataContext является IDisposable
using (var dataContext = new PersonalFileContext())
{
    //Отправляется первый запрос.
    var departmentTask = GetDepartments(userId, dataContext);
    //Отправляется второй запрос с использованием того же экземпляра класса PersonalFileContext
    var positionTask = GetPositions(userId, dataContext);

    // Происходит параллельное ожидание выполнения запросов. Создается новая задача, которая будет автоматически выполнена после выполнения всех предоставленных задач.
    // С помощью оператора await ожидаем ее завершения.
    await Task.WhenAll(departmentTask, positionTask);

    //DbContext не является потокобезопасным. Microsoft не рекомендует использовать один экземппляр несклькими потоками.
    // https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/#avoiding-dbcontext-threading-issues
    // В таком случае возможно некорректное выполнение запросов. Порядок получения результатов может быть любым. 
}   // у dataContext вызывается метод Dispose


//в сигнатуре метода исправлен тип DbContext на тип наследник,
//так как использование базового класса вместо класса наследника противоречит принципу подстановки Барбары Лисков
async Task<List<string>> GetDepartments(Guid userId, PersonalFileContext dc)
{
    // Создается запрос IQueryable<T>, где Т - string к таблице department, 
    var query = dc.Departments
        .Where(x => x.UserId == userId)
        .Select(x => x.Name);

    // Выполняется запрос.  Происходит отслеживание выполнения запроса, результат запроса приводится к типу List<string>.
    return await query.ToListAsync();
}


//в сигнатуре метода исправлен тип DbContext на тип наследник,
//так как использование базового класса вместо класса наследника противоречит принципу подстановки Барбары Лисков
async Task<List<PositionModel>> GetPositions(Guid userId, PersonalFileContext dc)
{
    // Создается запрос IQueryable<T>, где Т - PositionModel к таблице position, 
    var query = dc.Positions
    .Where(x => x.UserId == userId)
    .Select(x => new PositionModel
    {
        Id = x.Id,
        Kind = x.Type,
        Name = x.Name
    });

    // Выполняется запрос.  Происходит отслеживание выполнения запроса, результат запроса приводится к типу List<PositionModel>.
    return await query.ToListAsync();
}
