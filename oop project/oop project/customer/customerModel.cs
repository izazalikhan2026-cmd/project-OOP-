using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.customer
{
    
        public class customerModel
        {
            public List<string> BoughtProducts;
            public List<int> BoughtQuantities;
            public List<float> TotalBills;

             public customerModel()
             {
                 BoughtProducts = new List<string>();
                 BoughtQuantities = new List<int>();
                 TotalBills = new List<float>();
             }
        }
    }




