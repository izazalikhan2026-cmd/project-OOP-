using oop_project.product;
using oop_project.store;
using oop_project.customer;

namespace oop_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            storeUI ui = new storeUI();
            ui.Login();
            productService s = new productService();
            productRepo r = new productRepo();
            ui.ShowSellerMenu(s,r);
            
        }
    }
}
