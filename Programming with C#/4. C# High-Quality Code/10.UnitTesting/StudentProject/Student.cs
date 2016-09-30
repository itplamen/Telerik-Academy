namespace StudentProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private const int MINIMAL_ID = 10000;
        private const int MAXIMAL_ID = 99999;

        private static List<int> studentsID = new List<int>();
        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.ID = this.GenerateID();
            studentsID.Add(this.ID);
        }

        public string Name 
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int ID 
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < MINIMAL_ID || value > MAXIMAL_ID)
                {
                    throw new ArgumentOutOfRangeException("Student ID is not in the given range!");
                }

                if (this.IsIDExist(value) == true)
                {
                    throw new ArgumentException("Student ID already exist!");
                }

                this.id = value;
            }
        }

        public int GenerateID()
        {
            if (studentsID.Count == 0)
            {
                return MINIMAL_ID;
            }

            int lastStudentID = studentsID[studentsID.Count - 1];
            int nextStudentID = lastStudentID + 1;

            return nextStudentID;
        }

        public bool IsIDExist(int id)
        {
            if (studentsID.Count > 0)
            {
                for (int i = 0; i < studentsID.Count; i++)
                {
                    if (id == studentsID[i])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void DeleteAllStudentsID()
        {
            studentsID.Clear();
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\n" + "ID: " + this.ID + "\n";
        }
    }
}
