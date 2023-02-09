using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IListService<T>
    {
        List<T> GetItems();
    }
}
