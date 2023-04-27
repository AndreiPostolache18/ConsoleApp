using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDB1
{
    public class Teacher
    {
        public int TeacherID { get; set; }

        public string FirstName { get; set; }

        public string SurnameName { get; set; }

        public Grade Grade { get; set; }

        public Course Course { get; set; }

    }
}
