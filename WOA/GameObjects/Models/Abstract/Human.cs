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
        protected int energy;
        protected int hp;
        protected string name;

        public Human(string name, int hp, int energy)
        {
            this.Name = name;
            this.HP = hp;
            this.Energy = energy;
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }

            protected set
            {
                Validator.CheckIfNull(value, "The energy cannot be null");

                this.energy = value;
            }
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
