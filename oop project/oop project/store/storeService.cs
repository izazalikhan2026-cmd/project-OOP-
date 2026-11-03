using System;
using System.Collections.Generic;
using System.Text;

namespace oop_project.store
{
    public class storeService
    {
      public  storeModel model = new storeModel();
        public storeRepo repo = new storeRepo();

        public storeService()
        {
            
            repo.LoadStoreConfig(model);
        }
        public bool AuthenticateSeller(string enteredPassword)
        {
            return enteredPassword == model.AdminPassword;
        }
     
        public void UpdateStoreSettings(string newName, string newPassword)
        {
            model.StoreName = newName;
            model.AdminPassword = newPassword;
            repo.SaveStoreConfig(model);
        }
    }
}

