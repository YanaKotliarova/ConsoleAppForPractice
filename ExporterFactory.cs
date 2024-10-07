namespace ConsoleApp1
{
    internal class ExporterFactory : IExporterFactory
    {
        private readonly Func<IEnumerable<IDataExporter>> _factory;

        public ExporterFactory(Func<IEnumerable<IDataExporter>> factory)
        {
            _factory = factory;
        }

        public IDataExporter GetExporter(string name)
        {
            var set = _factory();
            IDataExporter output = set.Where(x => x.ExporterName == name).First();
            return output;
        }
    }


}
