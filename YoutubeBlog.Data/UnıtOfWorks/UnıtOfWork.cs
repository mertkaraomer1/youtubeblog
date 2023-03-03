using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repositories.Abstractions;
using YoutubeBlog.Data.Repositories.Concrates;

namespace YoutubeBlog.Data.UnıtOfWorks
{
    public class UnıtOfWork : IUnıtOfWork
    {
        private readonly AppDbContext dbContext;
        public UnıtOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
           return await dbContext.SaveChangesAsync();
        }

        IRepository<T> IUnıtOfWork.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }
    }
}
