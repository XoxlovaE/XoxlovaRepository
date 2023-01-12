using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    public interface IPaging
    {
        /// Пропустить страниц
        int Skip { get; }


        /// Получить строк
        int Take { get; }
    }
}
