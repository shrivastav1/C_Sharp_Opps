using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int result = ageCheck();
            Console.WriteLine(result);
        }
        catch (ExceptionTests t)
        {
            Console.WriteLine("Caught custom exception: " + t.Message);
        }
        catch (FormatException f)
        {
            Console.WriteLine("Invalid input! Please enter a valid number. " + f.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }

    }

    static int ageCheck()
    {
        Console.WriteLine("Enter Your Age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            throw new ExceptionTests("You Cann't Volt");
        }
        else { 
            Console.WriteLine("You can Volt");
        }
       
        return age;
    }
    }





