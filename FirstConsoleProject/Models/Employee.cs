using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleProject.Models
{
    class Employee
    {
        public string Fullname 
        {
            get;
            set;
        }
        private string _position;
        public string Position 
        {
            get => _position;

            set
            {

            } 
        }
        public double Salary 
        {
            get
            {
                return 0;
            }
            set
            {

            } 
        }
        public string DepartmentName 
        {
            get;



            set;
             
        }
        public string No 
        { 
            get;
            set; 
        }

        public Employee(string fullname, string position, double salary, string departmentname, string no)
        {
            Fullname = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;
            No = no;
        }



    }
}
