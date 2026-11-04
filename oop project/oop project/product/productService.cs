using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.product
{
    public class productService
    {
        public productRepo repo = new productRepo();
        public List<productModel> Products;

        public productService()
        {
            Products = repo.LoadProducts();
        }

        public void AddProduct(string name, string category, float price, int qty)
        {
            Products.Add(new productModel(name, category, price, qty));
            repo.SaveProducts(Products);
        }

        public void UpdateProduct(string target, string name, string category, float price, int qty)
        {
            foreach (var p in Products)
            {
                if (p.Name == target)
                {
                    p.Name = name;
                    p.Category = category;
                    p.Price = price;
                    p.Quantity = qty;
                    repo.SaveProducts(Products);
                    break;
                }
            }
        }
       

        public bool DeleteProduct(string target)
        {
           
            productModel toRemove = null;

           
            for (int i = 0; i < Products.Count; i++)
            {
               
                if (Products[i].Name.ToLower() == target.ToLower())
                {
                    toRemove = Products[i];
                    break; 
                }
            }

            
            if (toRemove != null)
            {
                Products.Remove(toRemove);       
                repo.SaveProducts(Products);    
                return true;                     
            }

            return false; 
        }
    }
}
