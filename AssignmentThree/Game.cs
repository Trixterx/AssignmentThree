using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Game
    {
        private bool wonGame, lostGame;
        Player player = new Player();
        static List<IMonster> listOfMonsters = new List<IMonster>();
        Random rnd = new Random();

        public void Start()
        {
            Setup();
            Menu();
        }

        private void Setup()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter your character name.");
            player.Name = Console.ReadLine();
            SpecificMonster specific = new SpecificMonster();
            listOfMonsters.Add(specific);
        }

        private void Menu()
        {
            int input;
            while (!wonGame && !lostGame)
            {
                Console.WriteLine("1. Go adventuring");
                Console.WriteLine("2. Show details about your character");
                Console.WriteLine("3. Exit game");
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
                Console.WriteLine("[Press any key to continue]");
                Console.ReadKey();
            }
            else
            {
                random = rnd.Next(listOfMonsters.Count);
                Fight(listOfMonsters[random]);
            }
        }

        private void ShowDetails()
        {
            Console.WriteLine($"Name: {player.Name}\nHealth Points: {player.Hp}\nLevel: {player.Lvl}\nExperience: {player.Exp}/{player.ExpToNxtLvl}\nDamage: {player.AtkDmg}\nGold: {player.Gold}");
            Console.WriteLine("[Press any key to continue]");
            Console.ReadKey();
        }

        private void Fight(IMonster monster)
        {
            Console.WriteLine(monster.getName());
        }
    }
}
