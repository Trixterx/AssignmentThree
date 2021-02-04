using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    class Lynx : Animal
    {
        public Lynx()
        {
            base.Name = "Lynx";
            base.Hp = 120;
            base.MaxHp = 120;
            base.Lvl = 3;
            base.Exp = 300;
            base.AtkDmg = 25;
            base.Gold = 120;
        }

        public override int attack()
        {
            Console.WriteLine("Mjaaau!");
            return base.attack();
        }
    }
}
