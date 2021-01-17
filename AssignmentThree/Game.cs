using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    public class Game
    {
        Player player = new Player();
        List<Monster> listOfMonsters = new List<Monster>();
        Random rnd = new Random();

        public void Start()
        {
            CreatePlayer();
            CreateMonsters();
            Menu();
        }

        public void CreatePlayer()
        {
            string input;
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter your character name.");
            input = Console.ReadLine();
            player.Name = input;
            player.Level = 1;
            player.HealthPoints = 200;
            player.Damage = 20;
            player.Experience = 0;
        }

        public void CreateMonsters()
        {

        }

        public void Menu()
        {
            int input;
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
                    break;
            }
        }

        public void Adventure()
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
                Fight();
            }
            Menu();
        }

        public void ShowDetails()
        {
            Console.WriteLine(player.Name);
            Menu();
        }

        public void Fight()
        {
            Console.WriteLine("Fight");
        }
    }
}
