using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trainning class
            Training training = new Training();
            training.TrainingDetails();
            Console.WriteLine("Training Fees : " + training.CalculateFees(3));
            Console.WriteLine();

            //ComputerTraining class
            ComputerTraining c1 = new ComputerTraining();
            c1.TrainingDetails();
            Console.WriteLine("Computer Training Fees : " + c1.CalculateFees(3));
            Console.WriteLine("Computer Training Project Fees : " + c1.CalculateFees(3, 5000));
            Console.WriteLine();

            //LanguageTraining class
            LanguageTraining l1 = new LanguageTraining();
            l1.TrainingDetails();
            Console.WriteLine("Language Training Fees : " + l1.CalculateFees(3));
            Console.WriteLine("Language Training Fees base on No of language : " + l1.CalculateFees(3, 500));
            Console.WriteLine();
        }
    }
}