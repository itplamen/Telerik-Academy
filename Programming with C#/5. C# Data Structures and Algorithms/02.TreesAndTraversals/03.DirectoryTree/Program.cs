//03.Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders } and using them build a 
//tree keeping all files and folders on the hard drive starting from C:\WINDOWS. Implement a method that calculates the sum of the file 
//sizes in given subtree of the tree and test it accordingly. Use recursive DFS traversal.

namespace _03.DirectoryTree
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private const string START_DIRECTORY = @"C:\Windows";

        public static void TraverseAllFilesAndFolders(string path, Folder folder)
        {
            try
            {
                foreach (var fileName in Directory.GetFiles(path))
                {
                    int fileSize = (int)(new FileInfo(fileName).Length);
                    File file = new File(fileName, fileSize);
                    folder.AddFile(file);
                }

                foreach (var directoryName in Directory.GetDirectories(path))
                {
                    folder.AddFolder(new Folder(directoryName));
                    TraverseAllFilesAndFolders(directoryName, folder.ChildFolders[folder.ChildFolders.Length - 1]);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            Folder root = new Folder(START_DIRECTORY);
            TraverseAllFilesAndFolders(START_DIRECTORY, root);
            int size = root.CalculateSize();
            Console.WriteLine(size);
        }
    }
}
