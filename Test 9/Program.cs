using Test_9;


var x = ListCreator.GetList(); //  Вычислений не происходит
var y = ListCreator.GetList().ToList(); // Ошибка OutOfMemoryException
var z = ListCreator.GetList().First();  //1
