using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPARTMENT
{
    

    public class Employee
    {
        public string No { get; set; }
        public string Fullname { get; set; }
        private string position;
        public string Position
        {
            get { return position; }
            set
            {
                if (value.Length > 2)
                {
                    throw new Exception("Vezife 2 herfden cox ola bilmez!");
                }
                position = value;
            }
        }

        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 250)
                {
                    throw new Exception("Salary cannot be less than 250");
                }
                salary = value;
            }
        }
        public string DepartmentName { get; set; }
    }

    public class Department
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 2)
                {
                    throw new Exception("Department adi minumum 2 herfden ibaret olmalidir!");
                }
                name = value;
            }
        }
        private int workerlimit;
        public int WorkerLimit
        {
            get { return workerlimit; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Isci sayi minumum 1 ola biler! ");
                }
                workerlimit = value;
            }
            }
        private decimal salarylimit;
        public decimal SalaryLimit
        {
            get { return salarylimit; }
            set
            {
                if(value < 250)
                {
                    throw new Exception("Ayliq Maas 250 den az ola bilmez!");
                }
                salarylimit = value;
            }
        }
        public List<Employee> Employees { get; set; }
        public decimal CalcSalaryAverage()
        {
            decimal totalSalary = 0;
            foreach (Employee employee in Employees)
            {
                totalSalary += employee.Salary;
            }
            return totalSalary / Employees.Count;
        }
    }

    public interface IHumanResourceManager
    {
        List<Department> Departments { get; }
        void AddDepartment(string name, int workerLimit, decimal salaryLimit);
        List<Department> GetDepartments();
        void EditDepartment(string name, string newName);
        void AddEmployee(string fullname, string position, decimal salary, string departmentName);
        void RemoveEmployee(string departmentName, string employeeNo);
        void EditEmployee(string employeeNo, string fullname, decimal salary, string position);
    }

    
}


