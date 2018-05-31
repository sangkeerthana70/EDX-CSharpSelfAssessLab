using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessLab1
{
   public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int YearOfGraduation { get; set; }
        //creates integer variable called "students" and assigns value to 0
        private static int students = 0;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            students++;
        }

 
        public Student(int yearofgraduation, string name)
        {
            this.Name = name;
            this.YearOfGraduation = yearofgraduation;
            students++;
        }

        public Student()
        {

        }

    }
}
