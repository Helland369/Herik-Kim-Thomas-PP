namespace Harrypotteroppgave {


    class Shop {

        private List<Inventory> shopItems = new List<Inventory> {
            new Animal("Per","cat","green","cat","cat",200000),
            new Animal("Fugl","ugle","white","ugle","ugle", 300000),
            new Animal("Råtti","råtte","grå","råtte","råtte", 12),
            new Wand("Harry potter wand","wand",400000,60000,3000),
            new Wand("Pheonix Stav","wand", 30000, 70000, 20000),
            new Wand("Troll Stav","wand",22,44,50),
        };

        public void ShopMenu()
        {
            Console.WriteLine("Welcome to the shop");
            Console.WriteLine("1. buy pet");
            Console.WriteLine("2. buy wand");
            string input = Console.ReadLine();

            foreach (var item in shopItems)
            {
                if (item is Animal animal)
                {
                    animal.PrintInfo();
                }
                else if (item is Wand wand)
                {
                    wand.PrintInfo();
                }
            }
        }
        
        
    }
}
