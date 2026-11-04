using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.product
{
    public class productUI
    {
        public void AddProductPrompt(productService prodService)
        {
            Console.Clear();
            Console.WriteLine("--------- ADD PRODUCT -----------");

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            float price = float.Parse(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            prodService.AddProduct(name, category, price, quantity);

            Console.WriteLine("Product added successfully!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        
        public void ViewAllProducts(productService prodService)
        {
            Console.Clear();
            Console.WriteLine("----------- ALL PRODUCTS -------------");

            if (prodService.Products.Count == 0)
            {
                Console.WriteLine("No products available.");
            }
            else
            {
                for (int i = 0; i < prodService.Products.Count; i++)
                {
                    var p = prodService.Products[i];
                    Console.WriteLine($"Product {i + 1}:");
                    Console.WriteLine($"  Name: {p.Name}");
                    Console.WriteLine($"  Category: {p.Category}");
                    Console.WriteLine($"  Price: {p.Price}");
                    Console.WriteLine($"  Quantity: {p.Quantity}\n");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

       
        public void FilterBycategory(productService prodService)
        {
            Console.Clear();
            Console.WriteLine("----------- SEARCH PRODUCT by CATAGORY -----------");
            Console.Write("Enter product category to filter: ");
            string searchcategory = Console.ReadLine();
            bool found = false;

            foreach (var p in prodService.Products)
            {
                if (p.Category == searchcategory && p.Price >=500)
                {
                    found = true;
                    Console.WriteLine("\n****** Product Found ******");
                    Console.WriteLine($"Name: {p.Category}");
                    Console.WriteLine($"Category: {p.Name}");
                    Console.WriteLine($"Price: {p.Price}");
                    Console.WriteLine($"Quantity: {p.Quantity}");
                }
            }

            if (!found)
            {
                Console.WriteLine("Product Not Found.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public void UpdateProductPrompt(productService prodService)
        {
            Console.Clear();
            Console.WriteLine("************ UPDATE PRODUCT *************");
            Console.Write("Enter Product Name to update: ");
            string targetName = Console.ReadLine();

            
            productModel existingProduct = prodService.Products.Find(p => p.Name.Equals(targetName, StringComparison.OrdinalIgnoreCase));

            if (existingProduct != null)
            {
                Console.Write("Enter new product name: ");
                string newName = Console.ReadLine();

                Console.Write("Enter new category: ");
                string newCategory = Console.ReadLine();

                Console.Write("Enter new price: ");
                float newPrice = float.Parse(Console.ReadLine());

                Console.Write("Enter new quantity: ");
                int newQuantity = int.Parse(Console.ReadLine());

                prodService.UpdateProduct(targetName, newName, newCategory, newPrice, newQuantity);
                Console.WriteLine("Product Updated Successfully!");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void DeleteProductPrompt(productService prodService)
        {
            Console.Clear();
            Console.WriteLine("========== DELETE PRODUCT ==========");
            Console.Write("Enter Product Name to delete: ");
            string targetName = Console.ReadLine();

            bool isDeleted = prodService.DeleteProduct(targetName);

            if (isDeleted)
            {
                Console.WriteLine("Product Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
    

