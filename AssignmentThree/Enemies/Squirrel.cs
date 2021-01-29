using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Squirrel : Monster
    {
        public Squirrel()
        {
            base.Name = "Squirrel";
            base.Hp = 100;
            base.MaxHp = 100;
            base.Lvl = 1;
            base.Exp = 100;
            base.AtkDmg = 20;
            base.Gold = 100;
        }

        public override string getName()
        {
            return base.getName();
        }

        public override int getHp()
        {
            return base.getHp();
        }

        public override int getExp()
        {
            return base.getExp();
        }

        public override int attack()
        {
            Console.WriteLine("Squirrlllllllll!");
            return base.attack();
        }

        public override void takeDamage(int dmg)
        {
            base.takeDamage(dmg);
        }

        public override int getGold()
        {
            return base.getGold();
        }

        public override bool isDead()
        {
            return base.isDead();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
