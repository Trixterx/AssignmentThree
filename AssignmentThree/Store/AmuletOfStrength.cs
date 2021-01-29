using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class AmuletOfStrength : Amulet
    {
        public AmuletOfStrength()
        {
            base.Name = "Amulet of Strenght";
            base.Price = 100;
            base.Strength = 50;
            base.Toughness = 0;
        }
    }
}
