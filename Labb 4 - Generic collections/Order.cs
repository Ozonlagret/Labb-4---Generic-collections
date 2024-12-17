using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Generic_collections
{
    internal class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public int OrderId => _orderId;
        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void WriteOrder()
        {
            decimal sum = 0;
            Console.WriteLine("Order " + _orderId + ":");
            foreach (MenuItem menuItem in _orderItems)
            {
                Console.WriteLine($"1 st {menuItem.Name}");
            }

            for (int i = 0; i < _orderItems.Count; i++)
            {
                sum = sum + _orderItems[i].Price;
            }
            Console.WriteLine("Summa: " + sum + " kr");

            Console.WriteLine($"Till bord nummer {_tableNumber}\n");
        }

        public void OrderNumber(Order order)
        {
            Console.WriteLine($"Beställning nr {_orderId} har lagts till.");
        }
    }
}
