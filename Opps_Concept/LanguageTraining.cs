using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class LanguageTraining : Training
    {
        public override void TrainingDetails()
        {
            Console.WriteLine("Language Training Details : In this course cover English, Germany, Spanish Language. ");
        }

        //method overriding
        public override double CalculateFees(int duration)
        {
            return duration * 500;
        }

        //method overlaoding
        public double CalculateFees(int languages, int fees)
        {
            return languages * fees;
        }
    }
}
