using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class ProgramStudentDelegate
    {
        static List<Student> lstStudent = new List<Student>() { 
        new Student{Id=1,Name="Anika",Marks=90},
        new Student{Id=2,Name="Avyaan",Marks=85},
        new Student{Id=3,Name="Vivan",Marks=95}
        };
        //public static void Main(string[] args)
        //{
        //    isDistinct isDistinct = new isDistinct(isStudentDistict);
        //    Student.CheckStudentDistinct(lstStudent, isDistinct);
        //}

        public static bool isStudentDistict(Student std)
        {
            if (std.Marks > 85)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    delegate bool isDistinct(Student std);
   class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public static void CheckStudentDistinct(List<Student> lstStudent,isDistinct isDistinct)
        {
            foreach(Student obj in lstStudent)
            {
                if(isDistinct(obj))
                {
                    Console.WriteLine(obj.Name + " passed with distict number");
                }

            }
        }

    }
}
