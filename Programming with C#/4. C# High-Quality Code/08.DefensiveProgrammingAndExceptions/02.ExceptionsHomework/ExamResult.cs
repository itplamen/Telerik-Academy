namespace _02.ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentOutOfRangeException("Grade cannot be negative or bigger than one hundred (100)!");
            }

            if (minGrade < 0 || minGrade > 100)
            {
                throw new ArgumentOutOfRangeException("Minimal grade cannot be negative or bigger than one hundred (100)!");
            }

            if (maxGrade < 0 || maxGrade > 100)
            {
                throw new ArgumentOutOfRangeException("Maximal grade cannot be negative or bigger than one hundred (100)!");
            }

            if (comments == string.Empty)
            {
                throw new ArgumentException("Comments value cannot be empty!");
            }

            if (comments == null)
            {
                throw new ArgumentNullException("Comments value cannot be null!");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade 
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Grade cannot be negative or bigger than one hundred (100)!");
                }

                this.grade = value;
            }
        }

        public int MinGrade 
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Minimal grade cannot be negative or bigger than one hundred (100)!");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade 
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Maximal grade cannot be negative or bigger than one hundred (100)!");
                }

                this.maxGrade = value;
            }
        }

        public string Comments 
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Comments value cannot be empty!");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("Comments value cannot be null!");
                }

                this.comments = value;
            }
        }
    }
}