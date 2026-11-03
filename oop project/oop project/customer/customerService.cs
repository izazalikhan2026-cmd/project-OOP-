using oop_project.customer;
using oop_project.product;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.customer
{
    public class customerService
    {
        public customerModel model = new customerModel();

        public string BuyProduct(List<productModel> products, string productName, int qty, productRepo prodRepo)
        {
            foreach (var p in products)
            {
                if (p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    if (qty <= p.Quantity)
                    {
                        p.Quantity -= qty;
                        prodRepo.SaveProducts(products); 

                        model.BoughtProducts.Add(p.Name);
                        model.BoughtQuantities.Add(qty);
                        model.TotalBills.Add(p.Price * qty);
                        return "Product Purchased Successfully";
                    }
                    else
                    {
                        return "Not Enough Stock Available";
                    }
                }
            }
            return "Product Not Found";
        }

        public (List<string>, List<int>, List<float>) GetBillData()
        {
            return (model.BoughtProducts, model.BoughtQuantities, model.TotalBills);
        }
    }
}