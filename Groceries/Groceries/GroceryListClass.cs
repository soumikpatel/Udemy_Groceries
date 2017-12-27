using System;
using System.Collections.Generic;
using System.Text;

namespace Groceries
{
    public class GroceryListClass
    {
        public string Name { get; set; }
        public List<ItemClass> Items { get; set; }
        public UserClass Owner { get; set; }
    }
}
