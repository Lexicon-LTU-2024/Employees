using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Robot
    {
        private string _name;
        //private const int x = 54;
        //private int _salary;

        //public int Salary
        //{
        //    get { return _salary; }
        //    set 
        //    { 
        //        if(value < 0)
        //        {
        //            _salary = 0;
        //        }
        //        else
        //        {
        //            _salary = value; 

        //        }
        //    }
        //}

        public int Salary { get; set; }

        public int Somethingelse;

        public Robot(string name, int salary)
        {
           _name = name;
           Salary = salary;
            
        }

        public void SetName(string value)
        {
            //Validate
            _name = value;
            Salary = 50;        }

        public string GetName()
        {
            return _name;
        }
    }
}
