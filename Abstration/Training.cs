using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstration
{
    public abstract class Training
    {
        public abstract void TrainingInfo();
        public void GetTrainingDetails()
        {
            Console.WriteLine("All Training Session will be online, also doubt session will be arrange at weekend.");
        }
    }
}
