using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Работници {
    class ContractEmployee : BaseEmployee {
        public ContractEmployee(string employeeID, string employeeName, string employeeAdress, string employeeTask, string employeeDepartment) : base(employeeID, employeeName, employeeAdress) {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }

        public string employeeTask { get; set; }
        public string employeeDepartment { get; set; }

        public override void Show() {
            base.Show();
            Console.WriteLine($"Task - {employeeTask}");
        }
        public override double CalculateSalary(int workingHours) {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment() => employeeDepartment;
    }
}
