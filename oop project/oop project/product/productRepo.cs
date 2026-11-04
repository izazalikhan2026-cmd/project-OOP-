using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.product
{
    public class productRepo
    {
        public  string filePath = "products.txt";

        public void SaveProducts(List<productModel> products)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var p in products)
                {
                    writer.WriteLine(p.Name);
                    writer.WriteLine(p.Category);
                    writer.WriteLine(p.Price);
                    writer.WriteLine(p.Quantity);
                }
            }
        }

        public List<productModel> LoadProducts()
        {
            List<productModel> products = new List<productModel>();
            if (!File.Exists(filePath))
            {
                products.Add(new productModel("laptop", "Electronics", 150000, 5));
                products.Add(new productModel("mobile", "Electronics", 200000, 10));
                products.Add(new productModel("iphhone", "Electronics", 10000, 15));
                products.Add(new productModel("samsung", "Electronics", 50000, 18));
                products.Add(new productModel("infinix", "Electronics", 80000, 20));

                products.Add(new productModel("mouse", "Accessories", 1500, 20));
                products.Add(new productModel("keyboard", "accessories", 3000, 10));
                return products;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string name = line;
                    string category = reader.ReadLine();
                    float price = float.Parse(reader.ReadLine());
                    int quantity = int.Parse(reader.ReadLine());
                    products.Add(new productModel(name, category, price, quantity));
                }
            }
            return products;
        }
    }
}
    

