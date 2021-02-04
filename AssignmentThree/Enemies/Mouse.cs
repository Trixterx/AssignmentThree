using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Mouse : Animal
    {
        public Mouse()
        {
            base.Name = "Mouse";
            base.Hp = 100;
            base.MaxHp = 100;
            base.Lvl = 1;
            base.Exp = 100;
            base.AtkDmg = 20;
            base.Gold = 100;
        }

        public override int attack()
        {
            Console.WriteLine("Pip pip!");
            return base.attack();
        }
    }
}
