using System;
using Autofac;
using Dependency.Models;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            //without container

            //Home home = new Home();
            //Person person = new Person(home);
            //person.TakeRest();

            ////person.School = new School();
            //person.School = new Collage();
            //person.GetEducation();

            //person.TakeCare(new Hospital());


            //======using container==============
            var container = ContainerConfigration.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                IPerson person = scope.Resolve<IPerson>();
                person.TakeRest();

                person.School = scope.Resolve<IEducation>();
                person.GetEducation();
               
                person.TakeCare(scope.Resolve<IHospital>());
            }
        }

    }
}