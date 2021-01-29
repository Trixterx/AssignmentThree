using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class Shop
    {
        List<Amulet> listOfItems = new List<Amulet>();
        private bool shopping = true;

        public void ShopMenu()
        {
            Console.WriteLine("hi");
            while (shopping)
            {

                Console.WriteLine("Shop");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. List amulets");
                Console.WriteLine("2. List Rings");
                Console.WriteLine("3. Exit shop");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ListAmulets();
                        break;
                    case 2:
                        ListRings();
                        break;
                    case 3:
                        shopping = false;
                        break;
                }
            }
        }

        private void ListAmulets()
        {
            foreach (Amulet amulet in listOfItems)
            {
                Console.WriteLine(amulet);
            }
        }

        private void ListRings()
        {

        }

        private void CreateItems()
        {
            listOfItems.Add(new AmuletOfStrength());
            listOfItems.Add(new AmuletOfToughness());
            listOfItems.Add(new AmuletOfAwesomeness());
        }
    }
}
