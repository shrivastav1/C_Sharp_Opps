using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    internal class LanguageCourse : BaseCourse
    {
        public LanguageCourse(string name, int duration) : base(name, duration)
        {
        }

        public void LanguageProgram()
        {
            Console.WriteLine("This is LanguageCoure Specific Program");
        }
    }
}
