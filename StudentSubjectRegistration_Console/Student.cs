using StudentSubjectRegistration_Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSubjectRegistration_Console
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        //public List<Subject> Subjects { get; set; }


        public Student(int id, string name, bool gender, int age)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            //Subjects = new List<Subject>();
        }

        //public void RegisterASubject(Subject subject)
        //{
        //    Subjects.Add(subject);
        //}
    }
}
