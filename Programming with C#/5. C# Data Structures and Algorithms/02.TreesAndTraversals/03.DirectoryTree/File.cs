namespace _03.DirectoryTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class File
    {
        private string name;
        private int size;

        public File(string name, int size)
        {
            this.Name = name;
            this.Size = size;
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
                    throw new ArgumentException("File name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int Size 
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be negative!");
                }

                this.size = value;
            } 
        }
    }
}
