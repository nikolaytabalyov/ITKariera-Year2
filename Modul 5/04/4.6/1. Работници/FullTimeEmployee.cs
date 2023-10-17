using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Работници {
    class FullTimeEmployee : BaseEmployee {
        public FullTimeEmployee(string employeeID, string employeeName, string employeeAdress, string employeePosition, string employeeDepartment) : base(employeeID, employeeName, employeeAdress) {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public string employeePosition { get; set; }
        public string employeeDepartment { get; set; }

        public override void Show() {
            base.Show();
            Console.WriteLine($"Position - {employeePosition}");
            Console.WriteLine($"Department - {employeeDepartment}");
        }
        public override double CalculateSalary(int workingHours) {
            throw new NotImplementedException();
        }

        public override string GetDepartment() {
            throw new NotImplementedException();
        }
    }
}
