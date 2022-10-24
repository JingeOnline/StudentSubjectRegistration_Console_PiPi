using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSubjectRegistration_Console
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hour { get; set; }

        public Subject(int id, string name,int hour)
        {
            Id= id;
            Name= name;
            Hour= hour;
        }
    }
}
