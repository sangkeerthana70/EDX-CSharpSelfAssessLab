using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessLab1
{
    public class Teacher
    {
        public string Department { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public Teacher(string department, string name,int experience)
        {
            this.Department = department;
            this.Experience = experience;
            this.Name = name;
        }

        public Teacher(int experience, string name)
        {
            this.Experience = experience;
            this.Name = name;
        }
    }
}
