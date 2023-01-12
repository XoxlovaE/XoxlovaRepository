using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_5
{
    internal static class QueryableExtentions
    {
       public static IQueryable<T> SearchByDictionaryName<T>(this IQueryable<T> context, string query) where T : IName
        {
            var pd = PredicateBuilder.New<T>();

            if (!string.IsNullOrEmpty(query))
            {
                //Все символы строки query переводятся в верхний регистр
                //происходит разделение строки query на массив строк, разделителем является пробел, удаляются сдвоенные пробелы.
                var inputWords = query.ToUpper().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in inputWords)
                {
                    // Вызывается метод, использующий элемент класса Т - Name. Это возможно, если для Т определен Name. Это можно сделать с помощью интерфейса INameble
                    pd.Or(o => o.Name.ToUpper().Contains(word));
                }
                context = context.Where(pd);
            }
            return context;
        }
    }
}
