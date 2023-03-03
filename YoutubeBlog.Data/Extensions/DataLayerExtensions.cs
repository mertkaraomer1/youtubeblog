
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repositories.Abstractions;
using YoutubeBlog.Data.Repositories.Concrates;
using YoutubeBlog.Data.UnıtOfWorks;

namespace YoutubeBlog.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection loadDataLayerExtensions(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("con")));
            services.AddScoped<IUnıtOfWork, UnıtOfWork>();

            return services;
        }
    }
}
