using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree.Enemies
{
    abstract class Monster : IMonster
    {
        private string name;
        private int lvl;
        private int hp;
        private int maxHp;
        private int exp;
        private int gold;
        private int atkDmg;
        private bool dead;

        Random rnd = new Random();

        public virtual string getName()
        {
            return this.name;
        }

        public virtual int getHp()
        {
            return this.hp;
        }

        public virtual int getMaxHp()
        {
            return this.maxHp;
        }

        public virtual int getExp()
        {
            return this.exp;
        }

        public virtual int attack()
        {
            return rnd.Next(1, atkDmg);
        }

        public virtual void takeDamage(int dmg)
        {
            this.hp -= dmg;
        }

        public virtual int getGold()
        {
            return this.gold;
        }

        public virtual bool isDead()
        {
            if (this.hp <= 0)
            {
                this.dead = true;
            }
            else
            {
                this.dead = false;
            }
            return this.dead;
        }

        public string Name { get => name; set => name = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int Exp { get => exp; set => exp = value; }
        public int Gold { get => gold; set => gold = value; }
        public int AtkDmg { get => atkDmg; set => atkDmg = value; }
        public bool Dead { get => dead; set => dead = value; }
    }
}
