using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    internal static class DifferensImplementationsFactory
    {
        public static void AddExporterFactory(this IServiceCollection services)
        {
            services.AddTransient<IDataExporter, ExcelExporter>();
            services.AddTransient<IDataExporter, XmlExporter>();

            services.AddSingleton<Func<IEnumerable<IDataExporter>>>(x => () =>  x.GetService<IEnumerable<IDataExporter>>()!);

            services.AddSingleton<IExporterFactory, ExporterFactory>();
        }
    }
}
