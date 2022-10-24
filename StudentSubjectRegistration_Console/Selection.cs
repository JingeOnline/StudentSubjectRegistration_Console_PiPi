using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSubjectRegistration_Console
{
    internal class Selection
    {
        internal int StudentId { get; set; }
        internal int SubjectId { get; set; }

        public Selection(int studentId,int subjectId)
        {
            StudentId = studentId;
            SubjectId = subjectId;
        }
    }
}
