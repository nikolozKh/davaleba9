using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace davaleba9
{
    internal class Employee
    {
        private string _name;
        private string _email;
        private string _phone;
        private string _job;
        private double _salary;

        public string Name{ get { return _name; } }
        public string Email{ get { return _email; } }
        public string Phone{ get { return _phone; } }
        public string Job{ get { return _job; } set { _job = value; } }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }


        }

        public Employee()
        {
            
        }
        public Employee(string name, string email, string phone, string job, double salary)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _job = job;
            _salary = salary;

        }

        public void print()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Email: {_email}");
            Console.WriteLine($"Phone: {_phone}");
            Console.WriteLine($"Job: {_job}");
            Console.WriteLine($"Salary: {_salary}");
        }

    }
}
