using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Moose : Animal
    {
        public Moose()
        {
            base.Name = "Moose";
            base.Hp = 140;
            base.MaxHp = 140;
            base.Lvl = 4;
            base.Exp = 400;
            base.AtkDmg = 40;
            base.Gold = 140;
        }

        public override int attack()
        {
            Console.WriteLine("Mooooooooooooose!");
            return base.attack();
        }
    }
}
