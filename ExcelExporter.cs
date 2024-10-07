namespace ConsoleApp1
{
    internal class ExcelExporter: IDataExporter
    {
        public string ExporterName { get; set; } = "ExcelExporter";
        public void CreateFile()
        {
            Console.WriteLine("Создан Excel файл");
        }
        public void ExportDataToFile()
        {
            Console.WriteLine("Экспортировано в Excel файл");
        }
    }
}
