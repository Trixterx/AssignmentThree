using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Player
    {
        private string name;
        private int lvl = 1;
        private int hp;
        private int maxHp = 200;
        private int atkDmg = 20;
        private int exp;
        private int expToNxtLvl = 100;
        private int gold;
        private bool isDead = true;

        Random rnd = new Random();

        public int attack(IMonster monster)
        {
            int dmg = rnd.Next(1, atkDmg);
            monster.takeDamage(dmg);
            return dmg;
        }

        public void takeDamage(int monsterdmg)
        {
            hp -= monsterdmg;
        }

        public int getGold(IMonster monster)
        {
            gold += monster.getGold();
            return gold;
        }

        public int getExp(IMonster monster)
        {
            exp += monster.getExp();
            return exp;
        }

        public void chkLvl()
        {
            if (exp == expToNxtLvl)
            {
                Lvl++;
                maxHp += 100;
                atkDmg += 10;
                exp = 0;
                expToNxtLvl += 100;
                hp = maxHp;
                Console.WriteLine($"Congrats you leveled up and are now level {Lvl} and healed to full HP: {hp}/{maxHp}");
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
        public bool IsDead { get => isDead; set => isDead = value; }
    }
}
