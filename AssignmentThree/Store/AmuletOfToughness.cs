using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class AmuletOfToughness : Amulet
    {
        public AmuletOfToughness()
        {
            base.Name = "Amulet of Toughness";
            base.Price = 100;
            base.Strength = 0;
            base.Toughness = 10;
        }
    }
}
