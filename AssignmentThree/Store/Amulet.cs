using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    class Amulet : Item
    {
        private int strength;
        private int toughness;

        public int Strength { get => strength; set => strength = value; }
        public int Toughness { get => toughness; set => toughness = value; }
    }
}
