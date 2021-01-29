using AssignmentThree.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Player
    {
        private string name;
        private int lvl = 1;
        private int hp = 200;
        private int maxHp = 200;
        private int atkDmg = 20;
        private int exp;
        private int expToNxtLvl = 100;
        private int gold;
        private bool dead;

        Random rnd = new Random();

        public int attack(IAnimal monster)
        {
            int dmg = rnd.Next(1, atkDmg);
            monster.takeDamage(dmg);
            return dmg;
        }

        public void takeDamage(int monsterdmg)
        {
            hp -= monsterdmg;
        }

        public int getGold(IAnimal monster)
        {
            gold += monster.getGold();
            return gold;
        }

        public int getExp(IAnimal monster)
        {
            exp += monster.getExp();
            return exp;
        }

        public void chkLvlUp()
        {
            if (exp >= expToNxtLvl)
            {
                Lvl++;
                maxHp += 100;
                atkDmg += 10;
                exp -= expToNxtLvl;
                expToNxtLvl += 100;
                hp = maxHp;
                Console.WriteLine($"Congrats you leveled up and are now level {Lvl}");
                Console.WriteLine($"You also healed to full HP: {hp}/{maxHp}");
            }
        }

        public bool isDead()
        {
            if (this.hp <= 0)
            {
                this.dead = true;
            }
            else
            {
                this.dead = false;
            }
            return this.dead;
        }

        public void godMode()
        {
            if (string.Equals(name.Trim(), "Robin", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hello Robin, GodMode Activated!");
                AtkDmg = 1000;
            }
        }

        public string Name { get => name; set => name = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }
        public int Exp { get => exp; set => exp = value; }
        public int ExpToNxtLvl { get => expToNxtLvl; set => expToNxtLvl = value; }
        public int Gold { get => gold; set => gold = value; }
        public bool Dead { get => dead; set => dead = value; }
    }
}
