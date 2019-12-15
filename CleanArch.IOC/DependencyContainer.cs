using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Data.Repository;
using CleanArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //App Layer
            services.AddScoped<ICourseService, CourseService > ();

            //Infra Data Layer
            services.AddScoped<ICourseRepo, CourseRepository>();
        }
    }
}
