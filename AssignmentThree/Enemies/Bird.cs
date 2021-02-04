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

        public override int attack()
        {
            Console.WriteLine("OOORororo!");
            return base.attack();
        }
    }
}

