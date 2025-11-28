using System;

namespace Studentadministration
{
    public class StudentInfo
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string StudyProgramme { get; private set; }
        public int StudentID { get; private set; }
        public List<SubjectInfo> SubjectsList { get; private set; }
        public List<GradesInfo> GradesList { get; private set; }


        public StudentInfo(string name, int age, string studyprogramme, 
                            int studentid, List<SubjectInfo> subjectlist, 
                            List<GradesInfo> gradeslist)
        {
            Name = name;
            Age = age;
            StudyProgramme = studyprogramme;
            StudentID = studentid;
            SubjectsList = subjectlist;
            GradesList = gradeslist;

        }

        public void showGrades()
        {
            foreach(var grade in GradesList)
            {
                Console.WriteLine(grade.Grade);
            }
        }
    }
}

