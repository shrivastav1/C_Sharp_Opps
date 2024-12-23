using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Training
    {
        public virtual void TrainingDetails()
        {
            Console.WriteLine("This is a general training details.");
        }
        public virtual double CalculateFees(int duration)
        {
            return duration * 200;
        }
    }
}
