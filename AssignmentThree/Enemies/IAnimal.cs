using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    interface IAnimal
    {
        public int attack();

        public void takeDamage(int dmg);

        public bool isDead();

        public string getName();

        public int getHp();

        public int getMaxHp();

        public int getExp();

        public int getGold();
    }
}
