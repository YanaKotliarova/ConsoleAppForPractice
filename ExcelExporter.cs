namespace ConsoleApp1
{
    internal class ExcelExporter: IDataExporter
    {

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
