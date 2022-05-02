using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleProject.Models
{
    internal class Department
    {
        private static int _num;

        public string Name 
        { 
            get; 
            set; 
        }
        public int WorkerLimit 
        { 
            get;
            set; 
        }
        public int SalaryLimit 
        { 
            get;
            set;
        }
        
        public Employee[] Employees;
    

        static Department()
        {
            _num = 1000;
        }
        public Department()
        {
            Employees = new Employee[0];
        }

        public double CalcSalaryAverage()
        {
            return 1.2;
        }

    }
}
