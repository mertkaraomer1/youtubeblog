﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.Services.Abractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticleAsync();
    }
}
