using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Dependency.Models;
using IContainer = Autofac.IContainer;

namespace Dependency
{
    public class ContainerConfigration
    {
        public static IContainer Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Person>().As<IPerson>();
            builder.RegisterType<Collage>().As<IEducation>();
            //builder.RegisterType<School>().As<IEducation>(); // change only here to get output from school
            builder.RegisterType<Hospital>().As<IHospital>();
            builder.RegisterType<Home>().As<IHome>();
            return builder.Build();
        }
       
    }
}
