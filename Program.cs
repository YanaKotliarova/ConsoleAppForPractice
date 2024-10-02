using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

public class Program
{

    public static void Main(string[] args)
    {

        var services = new ServiceCollection()
            .AddTransient<IDataExporter, ExcelExporter>()
            .AddTransient<Exporter>();

        using var serviceProvider = services.BuildServiceProvider();

        var exporter = serviceProvider.GetService<Exporter>();
        exporter?.Export();



        services.AddTransient<IDataExporter, XmlExporter>();

        using var serviceProvider2 = services.BuildServiceProvider();

        exporter = serviceProvider2.GetService<Exporter>();
        exporter?.Export();

    }

}