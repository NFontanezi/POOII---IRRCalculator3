
using IRRCalculator3.Domain;
using IRRCalculator3.Domain.Enum;
using IRRCalculator3.Domain.Entities;
using IRRCalculator3.Services;
using Microsoft.Extensions.DependencyInjection;
using IRRCalculator3.ProjectFlows.Interfaces;
using IRRCalculator3.Services.Interfaces;
using IRRCalculator3.ProjectFlows;

namespace IRRCalculator3
{
    public class Program
    {
        static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            var mainFlowProvider = serviceProvider.GetService<IMainFlow>();
            var TaxCalculatorProviderProvider = serviceProvider.GetService<ITaxCalculator>();
            var PercentualRangeProvider = serviceProvider.GetService<IPercentualRange>();
            var RangeProvider = serviceProvider.GetService<IRange>();
            var TaxProvider = serviceProvider.GetService<ITax>();

            mainFlowProvider.BeginCalculator();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMainFlow, MainFlow>();
            services.AddScoped<ITaxCalculator, TaxCalculator>();
            services.AddScoped<IPercentualRange, PercentualRange>();
            services.AddScoped<IRange, RangeS>();
            services.AddScoped<ITax, Tax>();

        }


    }
}
