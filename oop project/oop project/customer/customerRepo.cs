using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.customer
{
    public class customerRepo
    {
        public string filePath = "customers.txt";

        
        public void SaveCustomerData(List<string> boughtProducts, List<int> boughtQuantities, List<float> totalBills)
        {
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                for (int i = 0; i < boughtProducts.Count; i++)
                {
                    writer.WriteLine(boughtProducts[i]);
                    writer.WriteLine(boughtQuantities[i]);
                    writer.WriteLine(totalBills[i]);
                }
            }
        }

        
        public void LoadCustomerData(customerModel model)
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string part;
                while ((part = reader.ReadLine()) != null)
                {
                    model.BoughtProducts.Add(part);
                    model.BoughtQuantities.Add(int.Parse(reader.ReadLine()));
                    model.TotalBills.Add(float.Parse(reader.ReadLine()));
                }
            }
        }
    }
}
    

