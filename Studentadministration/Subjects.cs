using System;

namespace Studentadministration
{ public class SubjectInfo
    {
            public string Subject { get; private set; }
            public int SubjectCode { get; private set; }
            public int StudyPoints { get; private set; }


            public SubjectInfo(string subject, int subjectcode, int studypoints)
            {
                Subject = subject;
                SubjectCode = subjectcode;
                StudyPoints = studypoints;
            }
        
    }
}

