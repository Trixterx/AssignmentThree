using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    public class Monster
    {
        private string name;

        public Monster()
        {

        }

        public Monster(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
