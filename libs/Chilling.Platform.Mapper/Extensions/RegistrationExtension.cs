using Chilling.Platform.Mapper.Abstracts;
using Microsoft.Extensions.DependencyInjection;

namespace Chilling.Platform.Mapper.Extensions
{
    public static class RegistrationExtension
    {
        public static void AddSimpleMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, Mapper>();

            Mapper.Init();
        }
    }
}
