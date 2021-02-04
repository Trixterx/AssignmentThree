using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Fox : Animal
    {
        public Fox()
        {
            base.Name = "Fox";
            base.Hp = 150;
            base.MaxHp = 150;
            base.Lvl = 5;
            base.Exp = 500;
            base.AtkDmg = 50;
            base.Gold = 500;
        }

        public override int attack()
        {
            Console.WriteLine("Foxy!");
            return base.attack();
        }
    }
}
