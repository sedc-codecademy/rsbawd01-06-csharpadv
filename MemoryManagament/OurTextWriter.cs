namespace MemoryManagament
{
    public class OurTextWriter : IDisposable
    {
        private string _path;
        private bool _disposedValue = false;

        private StreamWriter _streamWriter;

        public OurTextWriter(string path)
        {
            _path = path;

            _streamWriter = new StreamWriter(path, true);
        }
       
        public void Write(string content)
        {
            Console.WriteLine($"We are writing into file at {_path}");

            _streamWriter.WriteLine(content);
        }

        public void Dispose()
        {
            // clear all the resources here
            _streamWriter?.Dispose();
            _path = "";
            _disposedValue = true;

            Console.WriteLine("We are now disposing this class");
        }

    }
}
