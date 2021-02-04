using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Deer : Animal
    {
        public Deer()
        {
            base.Name = "Deer";
            base.Hp = 120;
            base.MaxHp = 120;
            base.Lvl = 2;
            base.Exp = 200;
            base.AtkDmg = 25;
            base.Gold = 120;
        }

        public override int attack()
        {
            Console.WriteLine("Muuuuju!");
            return base.attack();
        }
    }
}
