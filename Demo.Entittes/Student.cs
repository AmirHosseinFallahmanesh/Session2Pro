using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Entittes
{
   public class Student
    {

        public int StudentId { get; set; }

        public string Name { get; set; }
        public List<TeacherStudent> Teachers { get; set; }
    }

    public class TeacherStudent
    {
        public int TeacherStudentId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }


    public class Teacher
    {
        public int TeacherId { get; set; }
        public string  CourseName { get; set; }
        public string Name { get; set; }
        public List<TeacherStudent> Students { get; set; }
    }
}
