//02.Refactor the following if statements

namespace _02.RefactorIfStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        private const int MAX_X = 0;
        private const int MIN_X = 0;
        private const int MAX_Y = 0;
        private const int MIN_Y = 0;

        public static bool CheckX(int x)
        {
            if ((MIN_X <= x) && (x <= MAX_X))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public static bool CheckY(int y)
        {
            if ((MIN_Y <= y) && (y <= MAX_Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void VisitCell()
        {
            // TODO: Implement this method
            throw new NotImplementedException("Method VisitCell() is not implemented!");
        }

        public static void Main(string[] args)
        {
            // First statement to refactor
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.IsPeeled() && !potato.IsRotten())
                {
                    potato.Cook(potato);
                }
            }
            else
            {
                throw new NullReferenceException("Potato cannot be null!");
            }

            // Second statement to refactor
            int x = 0;
            int y = 0;
            bool shouldVisitCell = false;

            if (CheckX(x) && CheckY(y) && shouldVisitCell)
            {
                VisitCell();
            }
        }
    }
}
