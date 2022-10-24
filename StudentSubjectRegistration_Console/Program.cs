using StudentSubjectRegistration_Console;

Service service = new Service();
List<Student> students=service.GetInitialStudents();
List<Subject> subjects=service.GetInitialSubjects();
printStudentList(students);

Console.WriteLine("Please input student ID for selection subject...");
int input_StudentId = int.Parse( Console.ReadLine());

while(true)
{

    List<int> availableSubjectIdList = service.GetAvaiableSubjectIdByStudentId(input_StudentId);
    List<Subject> availableSubjectList = subjects.Where(x => availableSubjectIdList.Contains(x.Id)).ToList();
    printSubjectList(availableSubjectList);
    Console.WriteLine("Please input subject Id for registration...");
    int input_SubjectId = int.Parse(Console.ReadLine());
    service.Register(input_StudentId, input_SubjectId);
    Console.WriteLine("Continue register new subject? Y/N");
    string inputYN = Console.ReadLine();
    if (inputYN=="N")
    {
        break;
    }
    else
    {
        if (service.IsStudentRegistrationFull(input_StudentId))
        {
            Console.WriteLine("You have selected 4 subject. Please exit.");
            break;
        }
    }

}


void printStudentList(List<Student> students)
{
    Console.WriteLine("StudentId\tName\tGender\tAge");
    foreach (Student student in students)
    {
        string gender = student.Gender ? "Male" : "Female";
        Console.WriteLine($"{student.Id}\t{student.Name}\t{gender}\t{student.Age}");
    }
}
void printSubjectList(List<Subject> subjects)
{
    Console.WriteLine("{0,-15}{1,-15}{2,-15}","SubjectId","Name","Hour");
    foreach(Subject subject in subjects)
    {
        Console.WriteLine($"{subject.Id,-15}{subject.Name,-15}{subject.Hour,-15}");
    }
}
