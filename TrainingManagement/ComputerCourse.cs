using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class ComputerCourse : BaseCourse
    {
        public ComputerCourse(string name, int duration) : base(name, duration)
        {
        }

        public void ItProgram()
        {
            Console.WriteLine("This is ComputerCoure Specific Program");
        }
    }
}
