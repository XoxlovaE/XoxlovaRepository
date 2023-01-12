using System.Reflection;
using Test_6;


var g = Guid.Parse("313A371F-2599-480A-BB86-7D89DD9A4DD5");
var i = 5;
var genderGuid = new DictionaryItem<Guid>(g, "Мужской");
var genderInt = new DictionaryItem<int>(i, "Мужской");