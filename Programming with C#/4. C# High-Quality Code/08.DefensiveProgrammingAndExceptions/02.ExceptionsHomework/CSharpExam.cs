namespace _02.ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CSharpExam : Exam
    {
        private const int MIN_SCORE = 0;
        private const int MAX_SCORE = 100;
        private int score;

        public CSharpExam(int score)
        {
            if (score < MIN_SCORE || score > MAX_SCORE)
            {
                throw new ArgumentOutOfRangeException("Score value cannot be negative or bigger than one hundred (100)!");
            }

            this.Score = score;
        }

        public int Score 
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MIN_SCORE || value > MAX_SCORE)
                {
                    throw new ArgumentOutOfRangeException("Score value cannot be negative or bigger than one hundred (100)!");
                }

                this.score = value;
            }
        }
        
        public override ExamResult Check()
        {
            return new ExamResult(this.Score, MIN_SCORE, MAX_SCORE, "Exam results calculated by score.");
        }
    }
}