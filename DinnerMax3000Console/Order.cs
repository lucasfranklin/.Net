﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMax3000Console
{
    class Order
    {
        public List<MenuItem> items = new List<MenuItem>();

        public double Total
        {
            get
            {
                double calculatedTotal = 0;
                foreach(MenuItem item in items){
                    calculatedTotal = calculatedTotal + item.price;
                }
                return calculatedTotal;
            }
            
        }

    }
}
