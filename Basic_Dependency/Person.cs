using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    public class Person
    {
        private Home _home;
        private School _school;
        //private object _hospital; //not use beacuse use method injection

        //private Hospital _hospital;


        //public Person()
        //    {
        //        _home = new Home();
        //        _school = new School();
        //        _hospital = new Hospital();
        //    } //This is highly coupled

        public School School
        {
            set { _school = value; }
        }

        public Person(Home home)
        {
            _home = home; //construcation injection
            //_school = new School();
            //_hospital = new Hospital();
        }

        public void TakeRest()
        {
            _home.ProvideRest(this);
        }

    public void GetEducation()
        {
            if (_school != null)
            {
                _school.Education(this);
            }
            else
            {
                Console.WriteLine("Not set school!");
            }
        }

    public void TakeCare(Hospital hospital) //method injection
        {
            hospital.PresonCare(this);
        }

        
    }
}
