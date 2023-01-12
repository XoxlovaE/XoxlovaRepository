using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_4
{
    public static class ServerTypes
    {
        public static EnumItemDto Web = new EnumItemDto
        { Id = 1, Name = "Web-сервер получил запрос от пользователя" };

        public static EnumItemDto App = new EnumItemDto
        { Id = 2, Name = "App-сервер получил запрос от Web-сервера" };
    }
}
