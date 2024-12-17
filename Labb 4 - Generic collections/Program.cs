namespace Labb_4___Generic_collections
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
            List<MenuItem> orderMenu1 = new List<MenuItem>();
            orderMenu1.AddRange(new List<MenuItem> { menuItem1, menuItem2 });
            Order order1 = new Order(orderMenu1, 1);

            List<MenuItem> orderMenu2 = new List<MenuItem>();
            orderMenu2.AddRange(new List<MenuItem> { menuItem3, menuItem3, menuItem4 });
            Order order2 = new Order(orderMenu2, 5);

            List<MenuItem> orderMenu3 = new List<MenuItem>();
            orderMenu3.AddRange(new List<MenuItem> { menuItem2, menuItem4, menuItem1 });
            Order order3 = new Order(orderMenu3, 2);
            

            restaurant.CreateOrder(order1);
            restaurant.CreateOrder(order2);
            restaurant.CreateOrder(order3);

            Console.WriteLine("---------------------------------");

            // 5. Visa alla aktuella ordrar.
            restaurant.ShowOrders();
            Console.WriteLine("---------------------------------");
            // 6. Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();
            Console.WriteLine("---------------------------------");
            // 7. Visa nästa order på kö.
            restaurant.ShowNextOrder();
            Console.WriteLine("---------------------------------");
            // 8. Hantera en order.
            restaurant.HandleOrder();

            // 9. Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();
            Console.WriteLine("---------------------------------");
            // 10. Lägg till en ny order.
            List<MenuItem> orderMenu4 = new List<MenuItem>();
            orderMenu4.AddRange(new List<MenuItem> { menuItem4, menuItem4, menuItem4, menuItem2 });
            Order order4 = new Order(orderMenu4, 4);
            restaurant.CreateOrder(order4);

            // 11. Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();
            // 12. Hantera två ordrar.
            restaurant.HandleOrder();
            restaurant.HandleOrder();
            Console.WriteLine();
            // 13. Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();
            // 14. Visa nästa order på kö.
            restaurant.ShowNextOrder();
            // 15. Hantera en order.
            restaurant.HandleOrder();
            // 16. Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();

        }
    }
}
