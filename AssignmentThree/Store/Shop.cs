using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class Shop
    {
        List<Amulet> listOfAmulets = new List<Amulet>();
        private bool shopping;

        public void ShopMenu(Player player)
        {
            shopping = true;
            CreateAmulets();
            while (shopping)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Shop for Amulets");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. List amulets");
                Console.WriteLine("2. Buy");
                Console.WriteLine("3. Exit shop");
                Console.WriteLine("---------------------------------------");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ListAmulets();
                        break;
                    case 2:
                        BuyAmulet(player);
                        break;
                    case 3:
                        shopping = false;
                        break;
                }
            }
        }

        private void ListAmulets()
        {
            int counter = 1;
            foreach (Amulet amulet in listOfAmulets)
            {
                Console.WriteLine($"{counter}. {amulet.Name}\n   Strength: {amulet.Strength}\n   Toughness: {amulet.Toughness}\n   Price: {amulet.Price} gold\n");
                counter++;
            }
        }

        private void BuyAmulet(Player player)
        {
            Console.WriteLine("Which one do you wanna buy?");
            int choice = Convert.ToInt32(Console.ReadLine());

            Amulet chosenAmulet = listOfAmulets[choice - 1];

            if (player.Gold < chosenAmulet.Price)
            {
                Console.WriteLine("You can't afford this.");
            }
            else
            {
                player.Gold -= chosenAmulet.Price;
                player.Strength += chosenAmulet.Strength;
                player.Toughness += chosenAmulet.Toughness;
                Console.WriteLine($"You bought and equipped {chosenAmulet.Name}");
            }
        }
        
        private void CreateAmulets()
        {
            listOfAmulets.Add(new AmuletOfStrength());
            listOfAmulets.Add(new AmuletOfToughness());
            listOfAmulets.Add(new AmuletOfAwesomeness());
        }
    }
}
