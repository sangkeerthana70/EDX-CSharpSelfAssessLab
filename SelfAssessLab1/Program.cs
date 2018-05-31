using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a student object
            var Student1 = new Student("Anuradha", 40);
            var Student2 = new Student(2020, "Senthil");
            var Student3 = new Student(2020, "Keerthana");

            var Teacher1 = new Teacher("Computer Science","Sangeetha",7);

            var myCourse = new Course("Programming with C#");
            myCourse.Student1 = Student1;
            myCourse.Student2 = Student2;
            myCourse.Student3 = Student3;
            myCourse.Teacher1 = Teacher1;
            myCourse.studentCount = 3;

            var myDegree = new Degree("Bachelor",myCourse);

            var myProgram = new UProgram("Information Technology", myDegree);

            Console.WriteLine($"The name of the Program is {myProgram.Name}");
            Console.WriteLine($"The program has Degree {myProgram.Degree1.Name}");
            Console.WriteLine($"The program has Course {myProgram.Degree1.Course1.Name}");
            Console.WriteLine($"The program has {myCourse.studentCount} students");


        }
    }
}
