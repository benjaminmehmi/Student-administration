using System;

namespace Studentadministration
{
    internal class School
    {

        public List<SubjectInfo> subjectlist;

        public List<StudentInfo> studentlist;

        public List<GradesInfo> gradeslist;
        
        public School()
        {
            subjectlist = new List<SubjectInfo>
            {
                new SubjectInfo("Mathematics", 1034, 10),
                new SubjectInfo("Physics", 1037, 10),

            };
            
            gradeslist = new List<GradesInfo>
            {
                new GradesInfo(80177, 1034, 5),
                new GradesInfo(80111, 1037, 4),
            };

            studentlist = new List<StudentInfo>
            {
                new StudentInfo("Eric", 20, "Computer Science", 80177,
                    new List<SubjectInfo> { subjectlist[0] },
                    new List<GradesInfo> { gradeslist[0] }),
                new StudentInfo("Bob", 22, "Mechanical Engineering", 80111,
                    new List<SubjectInfo> { subjectlist[1] },
                    new List<GradesInfo> { gradeslist[1] })
            };
        }

        public void Run() 
        {
            bool appRunning = true;
            bool startUp = true;
            while (appRunning)
            {

                if (startUp)
                {
                    mainPage();
                    startUp = false;
                }


                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        showStudentInfo();
                        break;
                    case "2":
                        Console.Clear();
                        showSubjectInfo();
                        break;
                    case "3":
                        Console.Clear();
                        showGradeInfo();
                        break;
                    case "4":
                        Console.Clear();
                        appRunning = false;
                        Console.WriteLine("Exiting application.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void mainPage()
        {
            Console.WriteLine("Welcome to the student administration page, what would you like to access?");
            Console.WriteLine("__________________________________________________________________________\n");
            Console.WriteLine("  1. Enrolled students");
            Console.WriteLine("  2. Subjects");
            Console.WriteLine("  3. Grades");
            Console.WriteLine("  4. Exit\n");
        }
        public void showStudentInfo()
        {
            Console.WriteLine("Students in list:\n");
            foreach (StudentInfo student in studentlist)
            {
                Console.WriteLine($"  Name: {student.Name}, Age: {student.Age}, Study Programme: {student.StudyProgramme}\n");
            }

            Console.WriteLine("Press 1 to go back");
            string brukerValg = Console.ReadLine();
            if (brukerValg == "1")
            {
                Console.Clear();
                mainPage();
            }
        }

        public void showSubjectInfo()
        {
            Console.WriteLine("Subjects in list:\n");
            foreach (SubjectInfo subject in subjectlist)
            {
                Console.WriteLine($"  Subject: {subject.Subject}, Subject Code: {subject.SubjectCode}, Study Points: {subject.StudyPoints}\n");
            }

            Console.WriteLine("Press 1 to go back");
            string brukerValg = Console.ReadLine();
            if (brukerValg == "1")
            {
                Console.Clear();
                mainPage();
            }
        }

        public void showGradeInfo()
        {
            Console.WriteLine("Grades in list:\n");

            foreach (StudentInfo student in studentlist)
            {
                Console.WriteLine($"  Showing grades of student: {student.Name}\n");

                foreach (GradesInfo grade in gradeslist)
                {
                    Console.WriteLine($"     Subject: {grade.SubjectCode}, Grade: {grade.Grade}\n");
                }
            }

            Console.WriteLine("\nPress 1 to go back");
            string brukerValg = Console.ReadLine();
            if (brukerValg == "1")
            {
                Console.Clear();
                mainPage();
            }
        }
    }
}
