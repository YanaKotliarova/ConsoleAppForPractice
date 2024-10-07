namespace ConsoleApp1
{
    internal interface IDataExporter
    {
        public string ExporterName { get; set; }
        public void CreateFile();
        public void ExportDataToFile();
    }
}
