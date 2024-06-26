﻿using CRUDappWithORM.Business;
using CRUDappWithORM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappWithORM.Presentation {
    public class Display {
        private int _closeOperationId = 6;
        private ProductBusiness productBusiness = new ProductBusiness();

        public Display() {
            Input();
        }

        private void Input() {
            var operation = -1;
            do {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation) {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;

                }
            } while (operation != _closeOperationId);
        }

        private void Delete() {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product == null)
                Console.WriteLine("Product was not found!");

            productBusiness.Delete(id);
            Console.WriteLine("This product has been deleted!");
        }

        private void Fetch() {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null) {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine($"ID: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"Stock: {product.Stock}");
                Console.WriteLine(new string('-', 40));
            }
        }

        private void Update() {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Product product = productBusiness.Get(id);
            if (product != null) {
                Console.WriteLine("Current value for this product are:");
                Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.Stock}");
                Console.WriteLine("Enter name: ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter stock: ");
                product.Stock = int.Parse(Console.ReadLine());
                productBusiness.Update(product);
            } else {
                Console.WriteLine("Product not found!");
            }
        }

        private void Add() {
            Product product = new Product();
            Console.WriteLine("Enter name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter stock: ");
            product.Stock = int.Parse(Console.ReadLine());
            productBusiness.Add(product);
        }

        private void ListAll() {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "PRODUCTS");
            Console.WriteLine(new string('-', 40));
            var products = productBusiness.GetAll();
            foreach (var item in products) {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Stock}");
            }
        }

        private void ShowMenu() {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }
    }
}
