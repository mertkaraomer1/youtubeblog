using Microsoft.EntityFrameworkCore;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repositories.Abstractions;
using YoutubeBlog.Data.Repositories.Concrates;
using YoutubeBlog.Data.UnıtOfWorks;
using YoutubeBlog.Service.Services.Abractions;
using YoutubeBlog.Service.Services.Concrate;

namespace YoutubeBlog.Web.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection loadServiceLayerExtensions(this IServiceCollection services)
        {

            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
