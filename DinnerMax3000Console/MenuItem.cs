using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMax3000Console
{
   public class MenuItem
    {
        public string title;
        public string description;
        public double price
        {
            get { return _price; }
            set {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("You cannot have free or negative items values.");
                }
            }
        }

        private double _price;

    }
}
