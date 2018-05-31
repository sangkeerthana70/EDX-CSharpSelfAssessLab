using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessLab1
{
    public class Degree
    {
        public Course Course1 { get; set; }
        public String Name { get; set; }
        //constructor
        public Degree(String name, Course course1)
        {
            this.Course1 = course1;
            this.Name = name;
        }
    }
}

