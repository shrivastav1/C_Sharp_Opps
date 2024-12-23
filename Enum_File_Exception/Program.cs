using System;
using System.IO;
using System.Linq.Expressions;

namespace Enum_File_Exception
{
    //Enum for error type
    public enum ErrorType
    {
        IndexOutOfRange,
        DivisionByZero,
        GeneralError
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                printNumbers();  //IndexOutOfRange Exception
                DivisionNumber(); //DivisionByZero Exception
            }
            catch (Exception ex)
            {
                //check the error type using enums
                ErrorType errorType = ErrorType.GeneralError;


                //check the exception type and assign the error type
                if (ex is IndexOutOfRangeException)
                {
                    errorType = ErrorType.IndexOutOfRange;
                }
                else if (ex is DivideByZeroException)
                {
                    errorType = ErrorType.DivisionByZero;
                }

                //create error message
                string errorMessage = $"{DateTime.Now} => Error Type : {errorType}\nMessage : {ex.Message}\nStackTrace : {ex.StackTrace}\n";

                //error file path
                string errorFilePath = "E:/c#/Opps_Concept/Enum_File_Exception/error.txt";

                try
                {
                    Directory.CreateDirectory("E:/c#/Opps_Concept/Enum_File_Exception");
                    File.WriteAllText(errorFilePath, errorMessage);
                    Console.WriteLine($"Error logged to {errorFilePath}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to log error");
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void printNumbers()
        {
            try
            {
                string[] course = { "PHP", "Java", "C#", "Python", ".NET" };
                Console.WriteLine(course[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception("Index out of range", ex);
            }
        }


        private static void DivisionNumber()
        {
            try
            {
                double a = 22;
                double b = 0;
                double c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("Number Not Divisible by 0.", ex);
            }
        }

    }
}

