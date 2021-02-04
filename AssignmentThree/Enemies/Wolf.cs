using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Wolf : Animal
    {
        public Wolf()
        {
            base.Name = "Wolf";
            base.Hp = 130;
            base.MaxHp = 130;
            base.Lvl = 3;
            base.Exp = 300;
            base.AtkDmg = 30;
            base.Gold = 130;
        }

        public override int attack()
        {
            Console.WriteLine("Grrrrr!");
            return base.attack();
        }
    }
}
