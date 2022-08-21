using System;
using CompositePatternSolution.Model;

namespace CompositePatternSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder root = new Folder("Movies");
            root.AddItems(new File("abc", "750MB"));
            root.AddItems(new File("prq", "1000MB"));

            Folder comedy = new Folder("Comedy");
            comedy.AddItems(new File("lmo", "850MB"));
            comedy.AddItems(new File("xyz", "1.9GB"));
            root.AddItems(comedy);

            root.ShowDetails(0);
        }
    }
}
