using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.DB
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }



    partial class Student
    {
        public int? GradeId { get; set; }
        public Grade Grade { get; set; }
    }

    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
    }
}
