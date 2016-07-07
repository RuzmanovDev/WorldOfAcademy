namespace GameObjects.Models.Abstract
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    using Common;
    using GameObjects.Contracts;

    public abstract class Human : Creatures, IHuman
    {

        private int hp;

        public Human(string name, int hp) 
            : base(name)
        {
            this.HP = hp;
        }


        public int HP
        {
            get
            {
                return this.hp;
            }

            protected set
            {
                this.hp = value;
            }
        }

       
    }
}
