using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    //ICourseDetails Interface
    public interface ICourseDetails
    {
        string GetDetails(); //same method name
        int TotalCourseDuration();
    }

    //IStudnetDetails Interface
    public interface IStudentDetails
    {
        string GetDetails(); //same method name
        void EnrollStudent(string studentName); //with parameter
        int StudentId();
        string ContactDetails(string email);
    }

    //ITrainerDetails Interface
    public interface ITrainerDetails
    {
        string GetDetails(); //same method name
        int NoOfCourses(int course_no);
        string TrainerName(string trainerName);
        string ContactDetails(string phoneNumber);
    }
}
