using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMax3000Console
{
    public class Menu
    {
        public Menu()
        {
            items = new List<MenuItem>();

        }

        public string name;
        public List<MenuItem> items;

        public void addMenuItem(string title, string description, double price)
        {
            MenuItem item = new MenuItem();
            item.title = title;
            item.description = description;
            item.price = price;
            items.Add(item);
        }

    }
}
