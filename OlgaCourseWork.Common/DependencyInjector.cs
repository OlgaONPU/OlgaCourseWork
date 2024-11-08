using DataLayer.Models.Entity;
using Microsoft.Extensions.DependencyInjection;
using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.Common.Repositories;
using OlgaCourseWork.Common.Services;

namespace OlgaCourseWork.Common
{
    public static class DependencyInjector
    {
        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IAccessoryRepository, AccessoryRepository>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IDoorRepository, DoorRepository>();
            services.AddTransient<IFireplaceRepository, FireplaceRepository>();
            services.AddTransient<IHeatingSystemRepository, HeatingSystemRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            //also we can register dependency other type
            //services.AddTransient<IProductRepository<Door>, DoorRepository>();
            //services.AddScoped<IProductRepository<Accessory>, AccessoryRepository>();
            //services.AddScoped<IProductRepository<Fireplace>, FireplaceRepository>();
            //services.AddScoped<IProductRepository<HeatingSystem>, HeatingSystemRepository>();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IArticleService, ArticleService>();
            services.AddTransient<IDoorService, DoorService>();
            services.AddTransient<IAccessoryService, AccessoryService>();
            services.AddTransient<IFireplaceService, FireplaceService>();
            services.AddTransient<IHeatingSystemService, HeatingSystemService>();
            services.AddTransient<IProductServiceFactory, ProductServiceFactory>();
        }
    }
}
