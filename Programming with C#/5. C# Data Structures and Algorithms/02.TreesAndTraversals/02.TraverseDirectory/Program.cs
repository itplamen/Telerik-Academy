// 02.Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all files matching the mask *.exe. 
// Use the class System.IO.Directory.

namespace _02.TraverseDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private const string PATH = @"C:\Windows";
        private const string MASK = ".exe";

        public static void TraverseWindowsFolder(string path)
        {
            try
            {
                foreach (var file in Directory.GetFiles(path).Where(file => file.EndsWith(MASK)))
                {
                    Console.WriteLine(file);
                }

                // DFS
                foreach (var directory in Directory.GetDirectories(path))
                {
                    TraverseWindowsFolder(directory);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            TraverseWindowsFolder(PATH);
        }
    }
}
