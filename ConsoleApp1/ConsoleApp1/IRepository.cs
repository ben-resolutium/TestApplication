using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IRepository
    {
        Item GetItem(int id);
        List<Item> GetItems();
    }
}
