﻿namespace Labb_4___Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Skapa ett nytt objekt av Restaurant-klassen.
            Restaurant restaurant = new Restaurant();

            // 2. Lägg till fyra olika rätter i menyn.
            MenuItem menuItem1 = new MenuItem(1, "Kött och potatis", 69.00m);
            MenuItem menuItem2 = new MenuItem(2, "En endaste jordnöt", 99.00m);
            MenuItem menuItem3 = new MenuItem(3, "Sköldpadda", 89.00m);
            MenuItem menuItem4 = new MenuItem(4, "Maskrospaj", 79.50m);

            restaurant.AddtoMenu(menuItem1);
            restaurant.AddtoMenu(menuItem2);
            restaurant.AddtoMenu(menuItem3);
            restaurant.AddtoMenu(menuItem4);
            Console.WriteLine("---------------------------------");

            // 3. Skriv ut menyn.
            restaurant.ShowMenu();
            Console.WriteLine("---------------------------------");

            // 4. Skapa 3 st nya ordrar, med minst två olika rätter i varje,
            // och lägg till dem i orderkön (du kan hitta på bordsnummer för beställningarna).
            List<MenuItem> orderMenu1 = new List<MenuItem> { menuItem1, menuItem2 };
            Order order1 = new Order(orderMenu1, 1);
            restaurant.CreateOrder(order1);

            List<MenuItem> orderMenu2 = new List<MenuItem> { menuItem3, menuItem3, menuItem4 };
            Order order2 = new Order(orderMenu2, 5);
            restaurant.CreateOrder(order2);

            List<MenuItem> orderMenu3 = new List<MenuItem> { menuItem2, menuItem4, menuItem1 };
            Order order3 = new Order(orderMenu3, 2);
            restaurant.CreateOrder(order3);
            Console.WriteLine("---------------------------------");

            restaurant.ShowOrders();
            restaurant.ShowOrderCount();
            restaurant.ShowNextOrder();
            Console.WriteLine();
            restaurant.HandleOrder();
            restaurant.ShowOrderCount();
            
            List<MenuItem> orderMenu4 = new List<MenuItem> { menuItem4, menuItem4, menuItem4, menuItem2 };
            Order order4 = new Order(orderMenu4, 4);

            restaurant.CreateOrder(order4);
            restaurant.ShowOrderCount();
            restaurant.HandleOrder();
            restaurant.HandleOrder();
            Console.WriteLine();
            restaurant.ShowOrderCount();
            restaurant.ShowNextOrder();
            restaurant.HandleOrder();
            restaurant.ShowOrderCount();
        }
    }
}
