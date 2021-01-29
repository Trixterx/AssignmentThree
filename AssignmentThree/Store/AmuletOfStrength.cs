using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class AmuletOfStrength : Amulet
    {
        public AmuletOfStrength()
        {
            base.Name = "Amulet of Strength";
            base.Price = 100;
            base.Strength = 5;
            base.Toughness = 0;
        }
    }
}
