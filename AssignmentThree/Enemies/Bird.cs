using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Bird : Animal
    {
        public Bird()
        {
            base.Name = "Bird";
            base.Hp = 170;
            base.MaxHp = 170;
            base.Lvl = 7;
            base.Exp = 700;
            base.AtkDmg = 35;
            base.Gold = 170;
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
            Console.WriteLine("OOORororo!");
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

