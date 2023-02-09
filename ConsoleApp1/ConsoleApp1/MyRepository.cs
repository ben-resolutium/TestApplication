using System.Collections.Generic;

namespace ConsoleApp1
{
    public class MyRepository: IRepository
    {
        public Item GetItem (int id)
        {
            return new Item()
            {
                Id = 1,
                Name = "First Item",
                Description = "First Item in our repository."
            };
        }
        public List<Item> GetItems()
        {
            return new List<Item>()
            {
                new Item() { Id = 1, Name = "First Item", Description = "First Item in our repository."},
                new Item() { Id = 2, Name = "Second Item", Description = "Second Item in our repository."}
            };
        }
    }
}
