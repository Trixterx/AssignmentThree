using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentThree.Store
{
    abstract class Amulet
    {
        private string name;
        private int price;
        private int attackPower;
        private int hpIncrease;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int AttackPower { get => attackPower; set => attackPower = value; }
        public int HpIncrease { get => hpIncrease; set => hpIncrease = value; }
    }
}
