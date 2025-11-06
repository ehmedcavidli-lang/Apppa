using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Db
{
    public class Context
    {
        static Student[] students = new Student[0]  ;
        static Student student = new Student
        {
           FullName = "John Doe",
           Age = 1,

        };
        static Student student2 = new Student
        {
            FullName="Orxan Mirzeyev",
            Age = 2,
        };

        public static void StudentInfo()
        {
            students=new Student[] {student,student2} ;
            foreach(Student student in students)
            {
                Console.WriteLine($"Name: {student.FullName}, Age: {student.Age}");
            }
        }
    }
}
