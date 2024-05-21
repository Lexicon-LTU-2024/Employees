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

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set 
            { 
                if(value < 0)
                {
                    _salary = 0;
                }
                else
                {
                    _salary = value; 

                }
            }
        }

        //  public int Salary { get; set; }

        public int Somethingelse;

        public Robot(string name, int salary)
        {
           _name = name;
            //
        }

        public void SetName(string value)
        {
            //Validate
            _name = value;   
        }

        public string GetName()
        {
            return _name;
        }
    }
}
