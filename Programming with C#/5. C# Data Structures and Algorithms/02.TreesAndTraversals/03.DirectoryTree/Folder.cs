namespace _03.DirectoryTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Folder
    {
        private string name;
        private IList<File> files;
        private IList<Folder> childFolders;

        public Folder(string name)
        {
            this.Name = name;
            this.files = new List<File>();
            this.childFolders = new List<Folder>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Folder name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public File[] Files 
        {
            get
            {
                return this.files.ToArray();
            } 
        }

        public Folder[] ChildFolders
        {
            get
            {
                return this.childFolders.ToArray();
            }
        }

        public void AddFile(File file)
        {
            this.files.Add(file);
        }

        public void AddFolder(Folder folder)
        {
            this.childFolders.Add(folder);
        }

        public int CalculateSize()
        {
            int size = 0;

            foreach (var file in this.Files)
            {
                size += file.Size;
            }

            foreach (var childFolder in this.ChildFolders)
            {
                size += childFolder.CalculateSize();
            }

            return size;
        }

        public override string ToString()
        {
            return string.Format("Folder name: {0} -> subfolders count: {1}", this.Name, this.childFolders.Count);
        }
    }
}
