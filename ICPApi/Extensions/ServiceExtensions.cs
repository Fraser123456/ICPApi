using ICPApi.Filters;
using Microsoft.Extensions.DependencyInjection;
using ICP.Core.DataAccess.MongoAccess.Abstract;
using ICP.Core.DataAccess.MongoAccess.Concrete;
using ICP.Business.Managers.Concrete;
using ICP.Business.Managers.Abstract;
using ICP.Business.Helpers.CloudinaryHelper.Concrete;
using ICP.Business.Helpers.CloudinaryHelper.Abstract;

namespace ICPApi.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection BindServices(this IServiceCollection services)
        {
            #region Product
            services.AddScoped<IProductService, ProductManager>();

            #endregion

            #region ImageHelper

            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddScoped<IImageService, ImageManager>();

            #endregion

            services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));

            return services;
        }

        public static IServiceCollection BindFilters(this IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                //options.Filters.Add(typeof(TrackExecution));
                options.Filters.Add(typeof(ExceptionHandler));
            });

            return services;
        }
    }
}
