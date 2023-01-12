using System.Xml.Linq;
using Test_4;

var web= new EnumItemDto{ Id = 1, Name = "Web-сервер получил запрос от пользователя" };
var app = new EnumItemDto{ Id = 2, Name = "App-сервер получил запрос от Web-сервера" };
var example = new EnumItemDto { Id = 4, Name = "example" };

Compare(web);       //true
Compare(app);       // false, true если реализовать метод IEquatable.Equals
Compare(example);   // false в любом случае

bool Compare(EnumItemDto serverType)
{
    // Вариант1: 
    //Происходит сравнения двух объектов типа EnumItemDto. Это объекты, хранящиеся в куче по ссылке. В данной ситуации будут сравниваться две ссылки. 
    //Результат сравнения будет false, даже если Id  и Name первого элемента будут равны Id  и Name второго элемента
    //true если реализовать метод IEquatable.Equals
    if (serverType == ServerTypes.App)  return true;
    
    // Вариант2: 
    // Происходит сравнение двух объектов числового типа int. Сравнение происходит по значению. 
    // Если Id первого и второго элемента равны, результатом будет true
    if (serverType.Id == ServerTypes.Web.Id) return true;

    return false;
}

