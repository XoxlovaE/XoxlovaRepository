
using Test_5;

IQueryable<Person> persons = null;
var query = persons.SearchByDictionaryName("Igor Masha");

// persons.Where(x => x.Name == "Igor" || x.Name == "Masha");

