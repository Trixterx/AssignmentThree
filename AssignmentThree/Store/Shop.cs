using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class Shop
    {
        List<Amulet> listOfAmulets = new List<Amulet>();
        private bool shopping = true;

        public void ShopMenu(Player player)
        {
            CreateAmulets();
            while (shopping)
            {
                Console.WriteLine("Shop");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. List amulets");
                Console.WriteLine("2. Buy");
                Console.WriteLine("3. Exit shop");

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
            foreach (Amulet amulet in listOfAmulets)
            {
                Console.WriteLine($"{amulet.Name}\nStrength: {amulet.Strength}\nToughness: {amulet.Toughness}\nPrice: {amulet.Price} gold");
            }
        }

        private void BuyAmulet(Player player)
        {
            Console.WriteLine("Which one do you wanna buy?");
            int choice = Convert.ToInt32(Console.ReadLine());

            Amulet chosenAmulet = listOfAmulets[choice - 1];
            Console.WriteLine($"You bought and equipped {chosenAmulet.Name}");

            if (player.Gold < chosenAmulet.Price)
            {
                Console.WriteLine("You can't afford this.");
            }
            else
            {
                player.Gold -= chosenAmulet.Price;
                player.AtkDmg += chosenAmulet.Strength;
                player.MaxHp += chosenAmulet.Toughness;
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
