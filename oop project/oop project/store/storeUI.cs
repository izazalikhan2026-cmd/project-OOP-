using oop_project.product;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.store
{
   public  class storeUI
    {
       public storeService service = new storeService();
       public  productUI prodUi = new productUI();


        public bool Login()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine($"Login attempt {i + 1} of 3");
                Console.Write("Enter seller password: ");
                string pass = Console.ReadLine();

                if (service.AuthenticateSeller(pass))
                {
                    Console.WriteLine("Successfully logged in!");
                    Console.ReadKey();
                    return true;
                }
                Console.WriteLine("Wrong password!");
                Console.ReadKey();
            }
            return false;
        }

     
        public void ShowSellerMenu(productService prodService, productRepo prodRepo)
        {
            int choice = 0;
            while (choice != 6)
            {
                Console.Clear();
                Console.WriteLine("========== SELLER MENU ==========");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Search Product");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    prodUi.AddProductPrompt(prodService);
                }
                else if (choice == 2)
                {
                    prodUi.ViewAllProducts(prodService);
                }
                else if (choice == 3)
                {
                    prodUi.SearchProductPrompt(prodService);
                }
                else if (choice == 4)
                {
                    prodUi.UpdateProductPrompt(prodService);
                }
                else if (choice == 5)
                {
                    prodUi.DeleteProductPrompt(prodService);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Exiting Seller Menu...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Option! Press any key to try again.");
                    Console.ReadKey();
                }
            }
        }
    }
}
    

