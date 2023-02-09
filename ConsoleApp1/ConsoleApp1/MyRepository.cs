using System.Collections.Generic;

namespace ConsoleApp1
{
    public class MyRepository: IRepository
    {
        private IListService<Item> _listService { get; }

        public MyRepository() { }

        public MyRepository(IListService<Item> listService)
        {
            _listService = listService;
        }

        public Item GetItem (int id)
        {
            return new Item()
            {
                Id = id,
                Name = "First Item",
                Description = "First Item in our repository."
            };
        }
        public List<Item> GetItems()
        {
            return _listService.GetItems();
        }
    }
}
