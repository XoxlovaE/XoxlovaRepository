using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    public static class ListPageByExtensions
    {
        //В условиях задачи не указано, сколько строк на странице. Примем это количество равным 10
        public static IList<T> PageBy<T>(this IQueryable<T> query, IPaging paging, int stringsOnPage = 10)
        {
            var skipStrings = stringsOnPage * paging.Skip;
            if (paging != null)
            {
                var elements = query
                    .Skip(skipStrings)
                    .Take(paging.Take)
                    .ToList();
                return elements;
            }
            else
              return new List<T>();
        }
    }
}
