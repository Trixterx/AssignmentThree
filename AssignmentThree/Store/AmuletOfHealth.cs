using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class AmuletOfHealth : Amulet
    {
        public AmuletOfHealth()
        {
            base.Name = "Amulet of Health";
            base.Price = 100;
            base.AttackPower = 0;
            base.HpIncrease = 50;
        }
    }
}
