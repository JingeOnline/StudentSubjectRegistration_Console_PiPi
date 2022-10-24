using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSubjectRegistration_Console
{
    internal class Service
    {
        public List<Selection> SelectionList=new List<Selection>();

        public List<Student> GetInitialStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student(101,"adam",true, 20),
                new Student(102,"morris",true, 21),
                new Student(103,"ama",false, 18),
                new Student(104,"scott",true, 19),
                new Student(105,"Lily",false, 18),
                new Student(106,"shali",false, 20),
                new Student(107,"ama",false, 18),
                new Student(108,"Sam",true, 19),
                new Student(109,"sisiya",false, 17),
                new Student(110,"tanaka",false, 22),
            };
            return students;
        }

        public List<Subject> GetInitialSubjects()
        {
            List<Subject> subjects = new List<Subject>()
            {
                new Subject(201,"English", 40),
                new Subject(202,"Chinese", 45),
                new Subject(203,"Math", 50),
                new Subject(204,"Physics", 40),
                new Subject(205,"Chemistry", 38),
                new Subject(206,"PE", 20),
            };
            return subjects;
        }

        /// <summary>
        /// 返回该学生当前可选的所有课程（剩下啥课还没选过）
        /// </summary>
        /// <param name="id">传入学生ID</param>
        /// <returns></returns>
        public List<int> GetAvaiableSubjectIdByStudentId(int id)
        {
            //所有课程Id
            List<int> allSubject = GetInitialSubjects().Select(x=>x.Id).ToList();
            //该学生已经注册的课程Id
            List<int> alreadySelectedSubjects = SelectionList.Where(x=>x.StudentId==id).Select(x=>x.SubjectId).ToList();
            //返回两个集合的差集，就是该学生还未注册的课程Id
            List<int> avaliableSubjects= allSubject.Where(x => !alreadySelectedSubjects.Contains(x)).ToList();
            return avaliableSubjects;
        }

        /// <summary>
        /// 学生注册课程（创建一条新的Selection记录）
        /// </summary>
        /// <param name="studentId">学生ID</param>
        /// <param name="subjectId">课程ID</param>
        public void Register(int studentId,int subjectId)
        {
            SelectionList.Add(new Selection(studentId, subjectId));
        }

        /// <summary>
        /// 检查学生是否已经注册满4门课
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public bool IsStudentRegistrationFull(int studentId)
        {
            int studentSelectionCount = SelectionList.Where(x => x.StudentId == studentId).Count();

            return studentSelectionCount >= 4;
        }
    }
}
