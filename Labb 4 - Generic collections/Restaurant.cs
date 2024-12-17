using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labb_4___Generic_collections
{
    internal class Restaurant 
    {
        
        // List<T> för att representera menyn
        public List<MenuItem> menu = new List<MenuItem>();

        // Ska använda Queue<T> för beställningar (av klassen Order)
        public Queue<Order> orders = new Queue<Order>();
        // - AddtoMenu(MenuItem menuItem)`**: Lägger till en ny maträtt i menyn och loggar detta till konsolen.
        public void AddtoMenu(MenuItem menuItem)
        {
            menu.Add(menuItem);
            Console.WriteLine($"{menu.Last().Name} har lagts till i menyn.");
            

        }
        // - ShowMenu(): Skriver ut alla maträtter i menyn till konsolen.
        public void ShowMenu()
        {
            Console.WriteLine("Meny:");
            foreach (MenuItem menuItem in menu)
            {
                Console.WriteLine($"{menuItem} kr");
            }
        }
        // - CreateOrder(Order order)`**: Lägger till en ny beställning i kön och loggar detta till konsolen.
        public void CreateOrder(Order order)
        {
            orders.Enqueue(order);
            order.OrderNumber(order);
        }
        // - HandleOrder(): Hanterar (tar bort) den första beställningen i kön och loggar detta till konsolen.
        public void HandleOrder()
        {
            Console.WriteLine($"Order {orders.First().OrderId} är färdig");
            orders.Dequeue();
            
        }
        // - ShowOrders(): Skriver ut alla beställningar i kön till konsolen.
        public void ShowOrders()
        {
            Console.WriteLine("Aktuella beställningar:");
            foreach (Order order in orders)
            {
                order.WriteOrder();
            }
            Console.WriteLine("---------------------------------");
        }
        // - ShowNextOrder(): Skriver ut beställningen som är näst i kön till konsolen.
        public void ShowNextOrder()
        {
            Console.WriteLine($"Nästa order i kön: ");
            orders.First().WriteOrder();
        }
        // - ShowOrderCount(): Skriver ut antalet beställningar i kön till konsolen.
        public void ShowOrderCount()
        {
            Console.WriteLine($"Det är {orders.Count()} ordrar i kön");
            Console.WriteLine("---------------------------------");
        }
        // (Tips! Skapa en metod i Order-klassen som du kan kalla på för att skriva ut en beställning.
        // Den kan du sedan använda i alla metoder som skriver ut en eller flera beställningar.)*/
    }
}
