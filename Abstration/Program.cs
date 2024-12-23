using System;
using Abstration;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerTraining c1 = new ComputerTraining();
            c1.TrainingInfo();
            Console.WriteLine(c1.GetTrainername("Dharmik Shrivastav"));
            Console.WriteLine("Total Hours of Computer Training : " + c1.CalculateTotalHours(30, 2));
            c1.GetTrainingDetails();
            Console.WriteLine();

            LanguageTraining l1 = new LanguageTraining();
            l1.TrainingInfo();
            Console.WriteLine(l1.GetTrainername("Sakshi Shrivastav"));
            Console.WriteLine("Total Hours of language Training : " + l1.CalculateTotalHours(30, 2));
            l1.GetTrainingDetails();
        }
    }
}