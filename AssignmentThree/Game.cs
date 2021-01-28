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
            player.Hp = player.MaxHp;

            Ninja ninja = new Ninja();
            Robot robot = new Robot();
            Mouse mouse = new Mouse();
            Wolf wolf = new Wolf();
            listOfMonsters.Add(ninja);
            listOfMonsters.Add(robot);
            listOfMonsters.Add(mouse);
            listOfMonsters.Add(wolf);
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
            Console.WriteLine($"Name: {player.Name}\nHP: {player.Hp}\nLevel: {player.Lvl}\nExperience: {player.Exp}/{player.ExpToNxtLvl}\nDamage: {player.AtkDmg}\nGold: {player.Gold}");
            Console.WriteLine("[Press any key to continue]");
            Console.ReadKey();
        }

        private void Fight(IMonster monster)
        {
            Console.WriteLine($"You encountered: {monster.getName()}");

            while (!monster.isDead())
            {
                Console.WriteLine($"You hit {monster.getName()} for {player.attack(monster)} damage");
                Console.WriteLine($"{monster.getName()} HP: {monster.getHp()}/{monster.getMaxHp()}");

                if (monster.isDead())
                {
                    Console.WriteLine($"You killed {monster.getName()} and gained {monster.getExp()} experience");
                    listOfMonsters.Remove(monster);

                    player.Gold += monster.getGold();
                    player.Exp += monster.getExp();

                    if (player.Exp == player.ExpToNxtLvl)
                    {
                        player.Lvl++;
                        player.MaxHp += 100;
                        player.AtkDmg += 10;
                        player.Exp = 0;
                        player.ExpToNxtLvl += 100;
                        player.Hp = player.MaxHp;
                        Console.WriteLine($"Congrats you leveled up and are now level {player.Lvl} and healed to full HP: {player.Hp}/{player.MaxHp}");
                    }

                    if (player.Lvl == 10)
                    {
                        Console.WriteLine("You beat the game!");
                        wonGame = true;
                    }
                    return;
                }

                int monsterdmg = monster.attack();
                player.takeDamage(monsterdmg);
                Console.WriteLine($"{monster.getName()} hit you for {monsterdmg} damage");
                Console.WriteLine($"Your HP: {player.Hp}/{player.MaxHp}");

                Console.WriteLine("[Press any key to continue]");
                Console.ReadKey();
            }
        }
    }
}
