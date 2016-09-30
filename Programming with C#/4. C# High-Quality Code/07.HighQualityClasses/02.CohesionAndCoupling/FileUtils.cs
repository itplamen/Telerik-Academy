namespace _02.CohesionAndCoupling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            if (fileName == string.Empty)
            {
                throw new ArgumentException("Filename cannot be empty!");
            }

            if (fileName == null)
            {
                throw new ArgumentNullException("Filename cannot be null!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == string.Empty)
            {
                throw new ArgumentException("Filename cannot be empty!");
            }

            if (fileName == null)
            {
                throw new ArgumentNullException("Filename cannot be null!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
