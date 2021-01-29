using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    abstract class Amulet
    {
        private string name;
        private int price;
        private int strength;
        private int toughness;


        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Toughness { get => toughness; set => toughness = value; }
    }
}
