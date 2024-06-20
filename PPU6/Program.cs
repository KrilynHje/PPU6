using System.Security.Cryptography.X509Certificates;

namespace PPU6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Store> storeList = new List<Store>();
            storeList.Add(new Store("Carlings", "Clothing", 1));
            storeList.Add(new Store("Versace", "Clothing", 3));
            storeList.Add(new Store("Gucci", "Clothing", 3));
            storeList.Add(new Store("Meny", "Groceries", 2));
            storeList.Add(new Store("Kiwi", "Groceries", 1));
            storeList.Add(new Store("Bunnpris", "Groceries", 2));
            storeList.Add(new Store("Gamestop", "Games", 1));
            storeList.Add(new Store("Spaceworld", "Electronics", 2));
            storeList.Add(new Store("Apple Store", "Electronics", 3));
            storeList.Add(new Store("Elkjøp", "Electronics", 2));


            bool isRunning = true;

            while (isRunning)

            {
                Console.WriteLine("Welcome to the Store Manager App");
                Console.WriteLine("1. Show all Stores");
                Console.WriteLine("2. Add a store to to the Manager App");
                Console.WriteLine("3. Exit the manager App");


                var menuChoice = Console.ReadKey().KeyChar;
                switch (menuChoice)
                {


                    case '1':
                        Console.Clear();
                        ShowStores();
                        break;

                    case '2':
                        Console.Clear();
                        AddStore();
                        break;
                    case '3':
                        isRunning = false;
                        break;





                }






            }



            void ShowStores()
            {


                foreach (Store store in storeList)
                {
                    string pricepoint = "";


                    if (store.PriceValue == 1)
                    {
                        pricepoint = "Cheap";

                    }
                    else if (store.PriceValue == 2)
                    {
                        pricepoint = "Affordable";


                    }
                    else if (store.PriceValue == 3)
                    { pricepoint = "Very Expensive"; }

                    Console.WriteLine($"Name: {store.Name} \n Type {store.Type} \n Pricepoint: {pricepoint}");
                }



            }




            void AddStore()
            {
                Console.Clear();
                Console.WriteLine("Adding new store...");
                Console.WriteLine("Name of the store:");
                string storeName = Console.ReadLine();
                Console.WriteLine("what kind of store is this? \n");
                Console.WriteLine("Clothing \n Groceries \n Electronics \n Games \n Other \n");
                string type = Console.ReadLine();
                Console.WriteLine("Enter pricepoint level: \n");
                Console.WriteLine("1. Cheap \n 2. Affordable \n 3. Very Expensive");
                int pricepoint = int.Parse(Console.ReadLine());
                storeList.Add(new Store(storeName, type, pricepoint));
                Console.WriteLine("New store added successfully!");
                Console.WriteLine("\nPress any key to go back to the main menu.");

            }


        }
    }
}
