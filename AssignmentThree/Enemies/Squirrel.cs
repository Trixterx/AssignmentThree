using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Squirrel : Animal
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

        public override int attack()
        {
            Console.WriteLine("Squirrlllllllll!");
            return base.attack();
        }
    }
}
