using System;
using System.Collections.Generic;

namespace CompositePatternSolution.Model
{
    public class Folder: IStorage
    {
        private string _folderName;
        private List<IStorage> list = new List<IStorage>();

        public Folder(string foldername)
        {
            _folderName = foldername;
        }

        public void AddItems(IStorage storage)
        {
            list.Add(storage);
        }

        public void ShowDetails(int level)
        {
            Console.WriteLine(" " + _folderName);
            foreach(IStorage storage in list)
            {
                storage.ShowDetails(level++);
            }
        }
    }
}
