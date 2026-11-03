using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.product
{
    public  class productModel
    {
        public string Name;
        public string Category;
        public float Price;
        public int Quantity;

        public productModel(string name, string category, float price, int quantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
    }
}
    

