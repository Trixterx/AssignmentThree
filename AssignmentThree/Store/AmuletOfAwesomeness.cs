using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class AmuletOfAwesomeness : Amulet
    {
        public AmuletOfAwesomeness()
        {
            base.Name = "Amulet of Awesomeness";
            base.Price = 300;
            base.AttackPower = 200;
            base.HpIncrease = 200;
        }
    }
}
