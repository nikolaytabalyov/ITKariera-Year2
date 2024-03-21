using CRUDappWithORM.Business;
using CRUDappWithORM.Data.Models;
using CRUDappWithORMv2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDappWithORM.Presentation {
    public class Display {
        private int _closeOperationId = 6;
        private ProductBusiness productBusiness = new ProductBusiness();
        private CategoryBusiness categoryBusiness = new CategoryBusiness();

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
                        Console.WriteLine("Enter 1 for Product/ 2  for Category");
                        int command1 = int.Parse(Console.ReadLine());
                        ListAll(command1);
                        break;
                    case 2:
                        Console.WriteLine("Enter 1 for Product/ 2  for Category");
                        int command2 = int.Parse(Console.ReadLine());
                        Add(command2);
                        break;
                    case 3:
                        Console.WriteLine("Enter 1 for Product/ 2  for Category");
                        int command3 = int.Parse(Console.ReadLine());
                        Update(command3);
                        break;
                    case 4:
                        Console.WriteLine("Enter 1 for Product/ 2  for Category");
                        int command4 = int.Parse(Console.ReadLine());
                        Fetch(command4);
                        break;
                    case 5:
                        Console.WriteLine("Enter 1 for Product/ 2  for Category");
                        int command5 = int.Parse(Console.ReadLine());
                        Delete(command5);
                        break;
                    default:
                        break;

                }
            } while (operation != _closeOperationId);
        }

        private void Delete(int command) {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            if (command == 1) {
                Product product = productBusiness.Get(id);
                if (product == null)
                    Console.WriteLine("Product was not found!");

                productBusiness.Delete(id);
                Console.WriteLine("This product has been deleted!");
            } else {
                Category category = categoryBusiness.Get(id);
                if (category == null)
                    Console.WriteLine("Category was not found!");

                categoryBusiness.Delete(id);
                Console.WriteLine("This category has been deleted!");
            }
        }

        private void Fetch(int command) {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());

            if (command == 1) {
                Product product = productBusiness.Get(id);
                if (product != null) {
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine($"ID: {product.Id}");
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Price: {product.Price}");
                    Console.WriteLine($"Stock: {product.Stock}");
                    Console.WriteLine($"CategoryId: {product.CategoryId}");
                    Console.WriteLine($"Category Name: {product.Category.Name}");
                    Console.WriteLine(new string('-', 40));
                } else {
                    Console.WriteLine("Product not found!");
                }
            } else {
                Category category = categoryBusiness.Get(id);
                if (category != null) {
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine($"ID: {category.Id}");
                    Console.WriteLine($"Name: {category.Name}");
                    Console.WriteLine(new string('-', 40));
                } else {
                    Console.WriteLine("Category not found!");

                }
            }
        }

        private void Update(int command) {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());

            if (command == 1) {
                Product product = productBusiness.Get(id);
                if (product != null) {
                    Console.WriteLine("Current value for this product are:");
                    Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.Stock} {product?.CategoryId}");
                    Console.WriteLine("Enter name: ");
                    product.Name = Console.ReadLine();
                    Console.WriteLine("Enter price: ");
                    product.Price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter stock: ");
                    product.Stock = int.Parse(Console.ReadLine());
                    Console.Write("Do you want to add a category? Y for yes/ N for no");
                    if (Console.ReadLine().ToUpper() == "Y") {
                        Console.WriteLine("Enter categoryId: ");
                        product.CategoryId = int.Parse(Console.ReadLine());
                    }
                    productBusiness.Update(product);
                } else {
                    Console.WriteLine("Product not found!");
                }
            } else {
                Category category = categoryBusiness.Get(id);
                if (category != null) {
                    Console.WriteLine("Current value for this category are:");
                    Console.WriteLine($"{category.Id} {category.Name}");
                    Console.WriteLine("Enter Id: ");
                    category.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter name: ");
                    category.Name = Console.ReadLine();
                    categoryBusiness.Update(category);
                } else {
                    Console.WriteLine("Category not found!");
                }
            }
        }

        private void Add(int command) {
            if (command == 1) {
                Product product = new Product();
                Console.WriteLine("Enter name: ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter stock: ");
                product.Stock = int.Parse(Console.ReadLine());
                Console.Write("Do you want to add a category? Y for yes/ N for no: ");
                if (Console.ReadLine().ToUpper() == "Y") {
                    Console.WriteLine("Enter categoryId: ");
                    product.CategoryId = int.Parse(Console.ReadLine());
                }
                productBusiness.Add(product);
            } else {
                Category category = new Category();
                Console.WriteLine("Enter name: ");
                category.Name = Console.ReadLine();
                categoryBusiness.Add(category);
            }
        }

        private void ListAll(int command) {
            if (command == 1) {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string(' ', 16) + "PRODUCTS");
                Console.WriteLine(new string('-', 40));
                var products = productBusiness.GetAll();
                foreach (var item in products) {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Stock}");
                }
            } else {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string(' ', 16) + "CATEGORIES");
                Console.WriteLine(new string('-', 40));
                var categories = categoryBusiness.GetAll();
                foreach (var category in categories) {
                    Console.WriteLine($"{category.Id} {category.Name}");
                }
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
