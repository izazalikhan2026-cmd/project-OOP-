using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.store
{
    public class storeRepo
    {
        public string storeFilePath = "store_config.txt";

       
        public void SaveStoreConfig(storeModel storeModel)
        {
            using (StreamWriter writer = new StreamWriter(storeFilePath))
            {
                writer.WriteLine(storeModel.StoreName);
                writer.WriteLine(storeModel.AdminPassword);
            }
        }

      
        public void LoadStoreConfig(storeModel storeModel)
        {
            if (!File.Exists(storeFilePath))
            {
                return;
            }

            using (StreamReader reader = new StreamReader(storeFilePath))
            {
                string name = reader.ReadLine();
                if (name != null) storeModel.StoreName = name;

                string password = reader.ReadLine();
                if (password != null) storeModel.AdminPassword = password;
            }
        }
    }
}
    

