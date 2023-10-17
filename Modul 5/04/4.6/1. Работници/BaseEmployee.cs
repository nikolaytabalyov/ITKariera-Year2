using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Работници {
    public abstract class BaseEmployee {
        public BaseEmployee(string employeeID, string employeeName, string employeeAdress) {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAdress = employeeAdress;
        }

        public string employeeID { get; set; }
        public string employeeName { get; set; }
        public string employeeAdress { get; set; }

        public virtual void Show() {
            Console.WriteLine($"ID - {employeeID}, Name - {employeeName}, Adress - {employeeAdress}");
        }

        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}
