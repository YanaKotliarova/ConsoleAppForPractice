using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {

        var services = new ServiceCollection();
        services.AddExporterFactory();
        using var serviceProvider = services.BuildServiceProvider();

        var exporterFactory = serviceProvider.GetService<IExporterFactory>();

        var exporter = exporterFactory.GetExporter("ExcelExporter");

        exporter.CreateFile();
        exporter.ExportDataToFile();

        exporter = exporterFactory.GetExporter("XmlExporter");

        exporter.CreateFile();
        exporter.ExportDataToFile();

    }

}