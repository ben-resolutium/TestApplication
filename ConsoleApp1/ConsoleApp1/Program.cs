using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new MyRepository();
            var item = repo.GetItem(1);
            Console.WriteLine(item.Description);
            Console.ReadKey();
        }
    }
}
