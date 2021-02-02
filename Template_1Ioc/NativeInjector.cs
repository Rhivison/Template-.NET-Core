using Microsoft.Extensions.DependencyInjection;
using System;
using Template_1.Application.Interfaces;
using Template_1.Application.Services;

namespace Template_1Ioc
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
