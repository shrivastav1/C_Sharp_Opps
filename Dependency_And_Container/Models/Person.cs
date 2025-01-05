using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.Models
{
    public class Person : IPerson
    {
        private IHome _home;
        private IEducation _school;
        //private Hospital _hospital;


        //public Person()
        //    {
        //        _home = new Home();
        //        _school = new School();
        //        _hospital = new Hospital();
        //    } //This is highly coupled

        public IEducation School
        {
            set { _school = value; }
        }
        public Person(IHome home)
        {
            _home = home; //construcation injection

        }

        public void TakeRest()
        {
            _home.ProvideRest(this);
        }

        public void GetEducation()
        {
            if (_school != null)
                _school.Education(this);
        }

        public void TakeCare(IHospital hospital) //method injection
        {
            hospital.PresonCare(this);
        }

    }
}
