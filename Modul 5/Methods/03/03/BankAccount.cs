using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03 {
    class BankAccount {

        private int _id;
        private decimal _balance;

        public BankAccount(int id, decimal balance) {
            ID = id;
            Balance = balance;
        }
        public BankAccount(int id) {
            ID = id;
        }

        public BankAccount() { }

        public int ID { get => _id; set => _id = value; }
        public decimal Balance { get => _balance; set => _balance = value; }

        public void Deposit(decimal amount) => Balance += amount;
        public void Withdraw(decimal amount) => Balance -= amount;
        public override string ToString() => $"Account {ID}, balance {Balance}";
    }
}
