using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; set; }

        // Let's declare a static variable that maintains a list of all Item objects like this:
        private static List<Item> _instances = new List<Item> { };

        public Item(string description)
        {
            Description = description;
            _instances.Add(this); // New code.
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

				public static void ClearAll()
				{
					_instances.Clear();
				}
    }
}
