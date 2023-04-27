using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDB1
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }

        public Grade Grade { get; set; }
    }
}
