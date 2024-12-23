using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ComputerTraining : Training
    {
        public override void TrainingDetails()
        {
            Console.WriteLine("Computer Training Details : In this course cover Full Stack Developer, App Developer, Ethical Hacking. ");
        }

        //methos overriding
        public override double CalculateFees(int duration)
        {
            return duration * 1000;
        }

        //method overloading
        public double CalculateFees(int duration, int projectFees)
        {
            return duration * projectFees;
        }
    }
}
