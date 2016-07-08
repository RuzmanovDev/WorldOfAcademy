namespace GameObjects.Models.Abstract
{
    using Abstract;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameObjects.Contracts;
    using GameObjects.Enumerations;
    using GameObjects.Common;

    public abstract class Pet : Creature, IPet
    {

        public Pet(string name)
                : base(name)
        {
        }

        //TODO Maybe this shoud be void method and the string should be printed to another class
        public abstract string HelpMe(IStudent student);

        public override string ToString()
        {
            return $"Pet: {this.GetType().Name} {this.Name}";
        }
    }
}
