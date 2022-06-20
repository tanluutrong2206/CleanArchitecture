using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.CommandHandler;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Bus;
using CleanArchitecture.Infra.Data.Context;
using CleanArchitecture.Infra.Data.Repository;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain InMemoryBus Mediator
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain Handler
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application Layer
            services.AddScoped<ICourseService, CourseService>();

            // Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();
        }
    }
}
