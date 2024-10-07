namespace ConsoleApp1
{
    internal interface IExporterFactory
    {
        IDataExporter GetExporter(string name);
    }
}