using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Mouse : Monster
    {
        public Mouse()
        {
            base.Name = "Mouse";
            base.Hp = 120;
            base.MaxHp = 120;
            base.Lvl = 2;
            base.Exp = 150;
            base.AtkDmg = 25;
            base.DropGold = 120;
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
            Console.WriteLine("Pip pip!");
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
