namespace _02.ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams)
        {
            if (firstName == string.Empty)
            {
                throw new ArgumentException("Student first name cannot be empty!");
            }

            if (firstName == null)
            {
                throw new ArgumentNullException("Student first name cannot be null!");
            }

            if (lastName == string.Empty)
            {
                throw new ArgumentException("Student last name cannot be empty!");
            }

            if (lastName == null)
            {
                throw new ArgumentNullException("Student last name cannot be null!");
            }

            if (exams == null)
            {
                throw new ArgumentNullException("Cannot calculate average on missing exams!");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Student first name cannot be empty!");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("Student first name cannot be null!");
                }

                this.firstName = value;
            }
        }

        public string LastName 
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Student last name cannot be empty!");
                }

                if (value == null)
                {
                    throw new ArgumentNullException("Student last name cannot be null!");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams 
        {
            get
            {
                return this.exams;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot calculate average on missing exams!");
                }

                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            IList<ExamResult> results = new List<ExamResult>();

            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                throw new ArgumentNullException("Cannot calculate average on missing exams!");
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentException("Student " + this.FirstName + " " + this.LastName + " has no exams!");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();

            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}