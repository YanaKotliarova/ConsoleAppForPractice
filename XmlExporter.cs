namespace ConsoleApp1
{
    internal class XmlExporter: IDataExporter
    {
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
