// 01. Implement SelectionSorter.Sort() method using
// selection sort algorithm

// 02. Implement Quicksorter.Sort() method using
// quicksort algorithm

namespace Algorithms
{
    using System.Collections.Generic;

    public class Program
    {
        
        public static void Main()
        {
            var selectionSorter = new SelectionSorter<int>();
            selectionSorter.Sort(new[] { 10, 1, 11, 2, 0, -9, 8, 9, 10, 11, -9, 0, 11 });
                
        }
    }
}
