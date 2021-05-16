using System;
using System.Threading.Tasks;

namespace TPUM_2021.ServerPresentation
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using MainController controller = new MainController();
            await controller.StartServer();
            
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
