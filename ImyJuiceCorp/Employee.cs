using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImyJuiceCorp
{
    class Employee
    {
        private string fullNames;
        private string username;
        private string category;
        private string password;
        private float salary;

        //names property.
        public string FullNames
        {
            get
            {
                return fullNames;
            }
            set
            {
                fullNames = value;
            }


        }
        //username property
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        //Category property
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        //Password property
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        //salary property.
        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Employee(string fullNames, string username, string category, string password, float salary)
        {
            this.fullNames = fullNames;
            this.username = username;
            this.category = category;
            this.password = password;
            this.salary = salary;
        }

        public float SalaryPay(int employeeIndex)
        {
            //Console.WriteLine("Enter the employee category");
            //var categ = Console.ReadLine();
            Console.WriteLine("By default, you are supposed to pay " + this.Salary + " ugx to " + this.FullNames);
            Console.WriteLine("what is the hourly rate: ");
            var hourRate = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours were worked? ");
            var hoursWorked = float.Parse(Console.ReadLine());
            var amount = (hourRate * hoursWorked);
            Console.WriteLine("The amount due to be paid is "+ amount);

            return amount;

        }

        /*
        public void RemoveEmployee(int empIndex)
        {

        }
         */
    }
}
