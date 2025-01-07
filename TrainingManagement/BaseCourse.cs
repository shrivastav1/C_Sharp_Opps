using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystem
{
    public class BaseCourse : ICourseDetails, IStudentDetails, ITrainerDetails
    {
        public string courseName;
        public int durationInWeek;
        //public void BaseTraining(string name, int duration)
        //{
        //    courseName = name;
        //    durationInWeek = duration;

        //}

        public BaseCourse(string name, int duration)
        {
            courseName = name;
            durationInWeek = duration;
        }


        public void display()
        {
            Console.WriteLine($"coures name : {courseName}, duration : {durationInWeek}");
        }
        public void CourseName(string name)
        {
            Console.WriteLine($"Course Name: {name}");
        }
        //Implementation of ICourseDetails
        public string GetDetails()
        {
            return $"Course: {courseName}, Duration: {durationInWeek} Week";
        }

        public int TotalCourseDuration()
        {
            return 6; //durationInWeek
        }

        //Implementation of IStudentDetails
        string IStudentDetails.GetDetails() //use explicit for implementation
        {
            return $"Student enrolled in {courseName}";
        }
        public void EnrollStudent(string studentName)
        {
            Console.WriteLine($"Student {studentName} has been enrolled in {courseName}.");
        }
        public int StudentId()
        {
            return 11;
        }
        string IStudentDetails.ContactDetails(string email) //use explicit for implementation
        {
            return $"Student email: {email}";
        }

        //Implementation of ITrainerDetails
        string ITrainerDetails.GetDetails() //use explicit for implementation
        {
            return $"Trainer for {courseName}";
        }
        public int NoOfCourses(int course_no)
        {
            return course_no;
        }
        public string TrainerName(string trainerName)
        {
            return $"Trainer Name: {trainerName}";
        }
        string ITrainerDetails.ContactDetails(string phoneNumber) //use explicit for implementation
        {
            return $"Trainer contact: {phoneNumber}";
        }
    }
}
