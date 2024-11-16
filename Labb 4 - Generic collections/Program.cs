namespace Labb_4___Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I programklassen ska du göra följande:
            // 1. Skapa ett nytt objekt av Restaurant-klassen.
            Restaurant restaurant = new Restaurant();
            // 2. Lägg till fyra olika rätter i menyn.
            MenuItem menuItem1 = new MenuItem(1, "Kött och potatis", 60.00m);
            MenuItem menuItem2 = new MenuItem(2, "En endaste jordnöt", 100.00m);
            MenuItem menuItem3 = new MenuItem(3, "Sköldpadda", 90.00m);
            MenuItem menuItem4 = new MenuItem(4, "Maskrospaj", 70.50m);

            restaurant.AddtoMenu(menuItem1);
            restaurant.AddtoMenu(menuItem2);
            restaurant.AddtoMenu(menuItem3);
            restaurant.AddtoMenu(menuItem4);
            Console.WriteLine("---------------------------------");
            // 3. Skriv ut menyn.
            restaurant.ShowMenu(); 
            // 4. Skapa 3 st nya ordrar, med minst två olika rätter i varje, och lägg till dem i orderkön (du kan hitta på bordsnummer för beställningarna).
            // 5. Visa alla aktuella ordrar.
            // 6. Visa antalet ordrar i kön.
            // 7. Visa nästa order på kö.
            // 8. Hantera en order.
            // 9. Visa antalet ordrar i kön.
            // 10. Lägg till en ny order.
            // 11. Visa antalet ordrar i kön.
            // 12. Hantera två ordrar.
            // 13. Visa antalet ordrar i kön.
            // 14. Visa nästa order på kö.
            // 15. Hantera en order.
            // 16. Visa antalet ordrar i kön.

        }
    }
}
