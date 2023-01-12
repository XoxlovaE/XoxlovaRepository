

using Test1;


using var efContext = new EfContext();
// Из таблицы car извлекаются данные и для каждой строчки создается объект класса Car
// SELECT id AS Id model_name AS ModelName brand_name AS BrandName FROM car
IEnumerable<Car> cars = efContext.Set<Car>();
// Из множества объектов cars выбираются те, у которых Id>100. Результат приводится к типу List<Car>
var result = cars.Where(p => p.Id > 100).ToList();


// Создается запрос к таблице car
IQueryable<Car> carsQuery = efContext.Set<Car>();          
//Выполняется запрос к базе с условием Id>100. Результат приводится к типу List<Car>
//SELECT id AS Id model_name AS ModelName brand_name AS BrandName FROM car WHERE id>100
var secondResult = cars.Where(p => p.Id > 100).ToList();   
