using System;
namespace CompositePatternSolution.Model
{
    public class File : IStorage
    {
        private string _fileName;
        private string _fileSize;

        public File(string filename, string filesize)
        {
            _fileName = filename;
            _fileSize = filesize;
        }

        public void ShowDetails(int level)
        {
            Console.WriteLine("    " +_fileName + " | " +_fileSize);
        }
    }
}
