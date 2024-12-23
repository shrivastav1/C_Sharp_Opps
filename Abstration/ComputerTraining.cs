using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstration
{
    public class ComputerTraining : Training, ITrainingDetails 
    {
        //Training abstract class implementation
        public override void TrainingInfo()
        {
            Console.WriteLine("Computer Training will be start from 1st of January.Focuses on improving your Technical skill and coding skill. ");
        }

        //ITrainingDetails interface implementation

        public string GetTrainername(string trainerName)
        {
            return "Computer Trainer Name is " + trainerName;
        }
        public int CalculateTotalHours(int days, int hoursPerDay)
        {
            return days * hoursPerDay;
        }

    }
}
