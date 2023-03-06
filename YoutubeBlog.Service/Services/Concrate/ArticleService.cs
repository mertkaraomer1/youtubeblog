using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Data.UnıtOfWorks;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abractions;

namespace YoutubeBlog.Service.Services.Concrate
{
    public class ArticleService : IArticleService
    {
        private readonly IUnıtOfWork unıtOfWork;
        private readonly IMapper mapper;
        public ArticleService(IUnıtOfWork unıtOfWork,IMapper mapper) 
        {
            this.unıtOfWork = unıtOfWork;
            this.mapper=mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
           var article=await unıtOfWork.GetRepository<Article>().GetAllAsync();
           var map = mapper.Map<List<ArticleDto>>(article);
           return map;
            
        }
    }
}
