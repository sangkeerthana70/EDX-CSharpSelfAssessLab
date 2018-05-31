using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessLab1
{
    public class Course
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }
        public Student Student3 { get; set; }
        public Teacher Teacher1 { get; set; }
        public String Name { get; set; }
        public int studentCount = 0;
        //constructor
        public Course(Student student1, Teacher teacher1)
        {
            this.Student1 = student1;
            this.Teacher1 = teacher1;
        }
        public Course(String name)
        {
            this.Name = name;
        }
 
    }

}
