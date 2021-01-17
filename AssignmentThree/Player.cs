using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    public class Player
    {
        private string name;
        private int level;
        private int healthPoints;
        private int damage;
        private int experience;

        public Player()
        {

        }

        public Player(string name, int level, int healthPoints, int damage, int experience)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Damage = damage;
            this.Experience = experience;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int HealthPoints { get => healthPoints; set => healthPoints = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Experience { get => experience; set => experience = value; }
    }
}
