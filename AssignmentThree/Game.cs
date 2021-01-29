using AssignmentThree.Enemies;
using AssignmentThree.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Game
    {
        private bool wonGame, lostGame;
        Player player = new Player();
        Shop shop = new Shop();
        static List<IAnimal> listOfAnimals = new List<IAnimal>();
        Random rnd = new Random();

        public void Start()
        {
            PlayerSetup();
            CreateAnimals();
            Menu();
        }

        private void PlayerSetup()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter your character name.");
            player.Name = Console.ReadLine();
            player.godMode();
        }

        private void CreateAnimals()
        {
            listOfAnimals.Add(new Mouse());
            listOfAnimals.Add(new Squirrel());
            listOfAnimals.Add(new Deer());
            listOfAnimals.Add(new Wolf());
        }

        private void Menu()
        {
            int input;
            while (!wonGame && !lostGame)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Go adventuring");
                Console.WriteLine("2. Show details about your character");
                Console.WriteLine("3. Go to shop");
                Console.WriteLine("4. Exit game");
                Console.WriteLine("---------------------------------------");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Adventure();
                        break;
                    case 2:
                        ShowDetails();
                        break;
                    case 3:
                        shop.ShopMenu(player);
                        break;
                    case 4:
                        Console.WriteLine("Bye bye");
                        lostGame = true;
                        break;
                }
            }

            if (wonGame)
            {
                Console.WriteLine("Congrats. You won!");
            }
        }

        private void Adventure()
        {
            int random = rnd.Next(1, 11);
            if (random == 10)
            {
                Console.WriteLine("Nothing Happened");
            }
            else
            {
                random = rnd.Next(listOfAnimals.Count);
                Fight(listOfAnimals[random]);
            }
        }

        private void ShowDetails()
        {
            Console.WriteLine($"Name: {player.Name}\nHP: {player.Hp}/{player.MaxHp}\nLevel: {player.Lvl}\nExperience: {player.Exp}/{player.ExpToNxtLvl}\nDamage: {player.AtkDmg}\nGold: {player.Gold}");
        }

        private void Fight(IAnimal animal)
        {
            Console.WriteLine($"You encountered: {animal.getName()}");

            while (!animal.isDead() && !player.isDead())
            {
                Console.WriteLine($"You hit {animal.getName()} for {player.attack(animal)} damage");
                Console.WriteLine($"{animal.getName()} HP: {animal.getHp()}/{animal.getMaxHp()}");

                if (animal.isDead())
                {
                    Console.WriteLine($"You killed {animal.getName()} and gained {animal.getExp()} experience");

                    player.getGold(animal);
                    player.getExp(animal);
                    player.chkLvlUp();
                    listOfAnimals.Remove(animal);

                    if (player.Lvl == 10)
                    {
                        Console.WriteLine("You beat the game!");
                        wonGame = true;
                    }
                    return;
                }

                int animalDmg = animal.attack();
                player.takeDamage(animalDmg);
                Console.WriteLine($"{animal.getName()} hit you for {animalDmg} damage");
                Console.WriteLine($"Your HP: {player.Hp}/{player.MaxHp}");

                if (player.isDead())
                {
                    Console.WriteLine("You died! Game over!");
                    lostGame = true;
                }
            }
        }
    }
}
