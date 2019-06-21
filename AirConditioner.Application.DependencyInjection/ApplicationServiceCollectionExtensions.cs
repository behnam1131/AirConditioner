using AirConditioner.Application.Service;
using AirConditioner.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AirConditioner.Application.DependencyInjection
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IPieceService, PieceService>();
            services.AddTransient<ITimeManager, UtcTimeManager>();
            services.AddTransient<IPieceCostService, PieceCostService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IEngineVolumeService, EngineVolumeService>();
            services.AddTransient<IFactorPieceService, FactorPieceService>();
            services.AddTransient<IFactorService, FactorService>();
            services.AddTransient<IPieceService, PieceService>();
            services.AddTransient<IUserAssistantService, UserAssistantService>();
            services.AddTransient<IUserExpertService, UserExpertService>();
            services.AddTransient<IUserOperatorService, UserOperatorService>();
            services.AddTransient<IUserTechnicianService, UserTechnicianService>();
            services.AddTransient<IAirConditionerModelService, AirConditionerModelService>();
            services.AddTransient<IWorkService, WorkService>();
            services.AddTransient<IFactorWorkService, FactorWorkService>();
            //services.AddSingleton
            //services.AddScoped

            return services;
        }
    }
}
