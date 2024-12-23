using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstration
{
    public class LanguageTraining : Training, ITrainingDetails
    {
        //Training abstract class implementation
        public override void TrainingInfo()
        {
            Console.WriteLine("Language Training will be start from 1st of every month.Focuses on improving spoken and written communication ");
        }
       
        //ITrainingDetails interface implementation
        public string GetTrainername(string trainerName)
        {
            return "Language Trainer Name is " + trainerName;
        }
        public int CalculateTotalHours(int days, int hoursPerDay)
        {
            return days * hoursPerDay;
        }

        

       
    }
}
