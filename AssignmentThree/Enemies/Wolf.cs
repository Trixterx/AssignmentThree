using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Wolf : Monster
    {
        public Wolf()
        {
            base.Name = "Ninja";
            base.Hp = 130;
            base.MaxHp = 130;
            base.Lvl = 3;
            base.Exp = 200;
            base.AtkDmg = 30;
            base.Gold = 130;
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
            Console.WriteLine("Grrrrr!");
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
