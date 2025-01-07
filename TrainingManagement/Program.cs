using System;

namespace TrainingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerCourse c1 = new ComputerCourse("Java",6);
            Console.WriteLine("Computer Class Object");
            Console.WriteLine();
            c1.ItProgram(); //ComputerCourse specific method
            c1.CourseName("C#"); //BaseCourse method
            Console.WriteLine(c1.GetDetails()); // ICourseDetails
            c1.EnrollStudent("Dharmik"); //IStudentDetails
            Console.WriteLine(((IStudentDetails)c1).ContactDetails("shree@gmail.com"));  //IStudentDetails
            Console.WriteLine(c1.StudentId()); //IStudentDetails
            Console.WriteLine(((ITrainerDetails)c1).ContactDetails("+91 9909966066"));  //ITrainerDetails
            Console.WriteLine(c1.TrainerName("Sweta Shrivastav")); //ITrainerDetails

            Console.WriteLine();

            Console.WriteLine("Language Class Object");
            Console.WriteLine();
            LanguageCourse l1 = new LanguageCourse("C#", 8);
            l1.LanguageProgram(); //ComputerCourse specific method
            l1.TotalCourseDuration(); //ICourseDetails
            l1.CourseName(".NET"); //BaseCourse method
            Console.WriteLine(((IStudentDetails)l1).GetDetails()); //IStudentDetails
            Console.WriteLine(((ITrainerDetails)l1).GetDetails());  //ITrainerDetails
            Console.WriteLine(l1.NoOfCourses(2)); //ITrainerDetails 

            BaseCourse b1 = new BaseCourse("C#", 6);
            b1.CourseName("java");
            b1.display();


        }
    }
}
