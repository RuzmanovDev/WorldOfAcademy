using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Models.Abstract
{
    using Common;
    using GameObjects.Contracts;

    public abstract class Human : IHuman
    {
        private string name;
        private int hp;

        public Human(string name, int hp)
        {
            this.Name = name;
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

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                this.name = value;
            }
        }
    }
}
