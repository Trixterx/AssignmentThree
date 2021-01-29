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
            base.Strength = 10;
            base.Toughness = 10;
        }
    }
}
