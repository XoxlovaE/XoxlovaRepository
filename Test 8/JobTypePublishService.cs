using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_8
{
    public class JobTypePublishService : IJobTypePublishService
    {
        private readonly IDbContextFactory _dbContextFactory;  //Предполагаем, что фабрика потокобезобасна
                                                               //и на каждый вызов метода Create() возвращается новый экземпляр DbContext
          //private IList<PublishedJobTypeDto> _items;       

        public JobTypePublishService(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        //Тип возвращаемого значения IList<PublishedJobTypeDto> _items отличается от типа, указанного в сигнатуре метода
        public async Task<PublishedJobTypeDto[]> GetAllAsync(string name)  
        {
            // some logic
            
            var result=await FindData(name);   // Есть вероятность вызова этого метода одновременно несколькими потоками

            // some logic

            return result;                     //_items;
        }

        private async Task<PublishedJobTypeDto[]> FindData(string name)
        {
            using (var db = _dbContextFactory.Create())    // Есть вероятность создания разных экземпляров DbContext
            {                
                return await db.Set<JobType>()                                      
                    .Where(x => !x.RecordDeleted.HasValue && x.Name.Contains(name))
                    .Select(x=> new PublishedJobTypeDto { Id = x.ID, Code = x.Code, Name = x.Name })
                    .ToArrayAsync();

                //_items = new List<PublishedJobTypeDto>();

                //foreach (var item in items)
                //{
                //   При попытке одновременной записи несколькими потоками в _items может получиться некорректный результат
                //    _items.Add(new PublishedJobTypeDto { Id = item.ID, Code = item.Code, Name = item.Name });
                //}
            }
        }
    }
}
