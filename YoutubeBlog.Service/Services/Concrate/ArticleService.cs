using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Data.UnıtOfWorks;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abractions;

namespace YoutubeBlog.Service.Services.Concrate
{
    public class ArticleService : IArticleService
    {
        private readonly IUnıtOfWork unıtOfWork;
        public ArticleService(IUnıtOfWork unıtOfWork) 
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<List<Article>> GetAllArticleAsync()
        {
            return await unıtOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
