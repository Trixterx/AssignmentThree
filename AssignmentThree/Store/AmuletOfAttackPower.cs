using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class AmuletOfAttackPower : Amulet
    {
        public AmuletOfAttackPower()
        {
            base.Name = "Amulet of Attackpower";
            base.Price = 100;
            base.AttackPower = 50;
            base.HpIncrease = 0;
        }
    }
}
