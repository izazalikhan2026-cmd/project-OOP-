using oop_project.product;
using oop_project.store;

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
