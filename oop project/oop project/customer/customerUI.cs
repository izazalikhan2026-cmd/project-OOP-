using oop_project.product;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.customer
{
    public class customerUI
    {
        public  customerService service = new customerService();

        public void ShowMenu(List<productModel> products, productRepo prodRepo)
        {
            int choice = 0;
            while (choice != 6)
            {
                Console.Clear();
                Console.WriteLine("========== CUSTOMER MENU ==========");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Search Product");
                Console.WriteLine("3. Buy Product");
                Console.WriteLine("4. Generate Bill");
                Console.WriteLine("5. View Available Stock");
                Console.WriteLine("6. Exit");
                Console.Write("Enter Your Choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1 || choice == 5)
                {
                    Console.Clear();
                    Console.WriteLine("========== AVAILABLE PRODUCTS ==========");
                    foreach (var p in products)
                    {
                        Console.WriteLine($"Name: {p.Name} | Category: {p.Category} | Price: {p.Price} | Qty: {p.Quantity}");
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.Write("Enter Product Name to buy: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                    int qty = int.Parse(Console.ReadLine());

                    string result = service.BuyProduct(products, name, qty, prodRepo);
                    Console.WriteLine(result);
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    float grandTotal = 0;
                    Console.WriteLine("========== CUSTOMER BILL ==========");
                    var (prods, qties, bills) = service.GetBillData();

                    for (int i = 0; i < prods.Count; i++)
                    {
                        Console.WriteLine($"Product: {prods[i]} | Qty: {qties[i]} | Bill: {bills[i]}");
                        grandTotal += bills[i];
                    }

                    if (grandTotal == 0)
                        Console.WriteLine("No product is bought");
                    else
                        Console.WriteLine($"Total Bill = {grandTotal}");

                    Console.ReadKey();
                }
            }
        }
    }
}
