using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessLab1
{
    public class UProgram
    {
        
        public Degree Degree1 { get; set; }
        public String Name { get; set; }

       //constructor
        public UProgram(String name, Degree degree1)
        {
            this.Name = name;
            this.Degree1 = degree1;
        }

        public UProgram()
        {

        }

    }
}
