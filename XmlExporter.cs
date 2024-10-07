namespace ConsoleApp1
{
    internal class XmlExporter: IDataExporter
    {
        public string ExporterName { get; set; } = "XmlExporter";
        public void CreateFile()
        {
            Console.WriteLine("Создан Xml файл");
        }
        public void ExportDataToFile()
        {
            Console.WriteLine("Экспортировано в Xml файл");
        }
    }
}
