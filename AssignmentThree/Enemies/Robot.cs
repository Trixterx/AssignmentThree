using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Enemies
{
    class Robot : Monster
    {
        public Robot()
        {
            base.Name = "Robot";
            base.Hp = 100;
            base.MaxHp = 100;
            base.Lvl = 1;
            base.Exp = 100;
            base.AtkDmg = 20;
            base.DropGold = 100;
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
            Console.WriteLine("hi");
            return base.attack();
        }

        public override void takeDamage(int dmg)
        {
            base.takeDamage(dmg);
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
