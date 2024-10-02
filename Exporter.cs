namespace ConsoleApp1
{
    internal class Exporter
    {
        IDataExporter dataExporter;
        public Exporter(IDataExporter dataExporter)
        {
            this.dataExporter = dataExporter;
        }
        public void Export()
        {
            dataExporter.CreateFile();
            dataExporter.ExportDataToFile();
        }
    }
}
