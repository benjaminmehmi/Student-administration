using System;

namespace Studentadministration
{
    public class GradesInfo
    {
        public int StudentID { get; private set; }
        public int SubjectCode { get; private set; }
        public int Grade { get; private set; }


        public GradesInfo(int studentId, int subjectCode, int grade)
        {
            StudentID = studentId;
            SubjectCode = subjectCode;
            if (grade < 1 || grade > 6)
                throw new ArgumentException("Grade must be between 1 and 6.");
            Grade = grade;
        }

    }
}
