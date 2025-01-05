using System;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();
            Person person = new Person(home);
            person.TakeRest();

            person.School = new School();
            person.GetEducation();

            //person.TakeCare();
        }

    }
}