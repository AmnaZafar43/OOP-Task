using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1.BL
{
    internal class AbsoluteGradedCourse
    {
        private string courseName;
        private float marks;
        private string grade;

        public string CourseName { get => courseName; set => courseName = value; }
        public float Marks { get => marks; set => marks = value; }
        public string Grade { get => grade; set => grade = value; }
    }
}
