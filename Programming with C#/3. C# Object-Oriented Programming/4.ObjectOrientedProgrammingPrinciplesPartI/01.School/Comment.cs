using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class Comment
    {
        // Fields
        private List<string> inputComment;

        // Constructor
        public Comment()
        {
            this.InputComment = new List<string>();
        }

        // Properties
        public List<string> InputComment 
        {
            get { return this.inputComment; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Comment cannot be null!");
                }
                else
                {
                    this.inputComment = value;
                }
            }
        } 
      
        // Methods
        // Add comment
        public void AddComment(string inputComment)
        {
            InputComment.Add(inputComment);
        }

        // Print commentss
        public void PrintComment()
        {
            foreach (var element in InputComment)
            {
                Console.WriteLine("Comment: " + element);
            }
        }
    }
}
