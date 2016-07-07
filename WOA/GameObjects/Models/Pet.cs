namespace GameObjects.Models.Abilities 
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

    public class Pet : Creatures, IPet
    {
        private readonly PetType petType;

        public Pet(string name, PetType petType)
                : base(name)
        {
        }

        public PetType PetType
        {
            get
            {
                return this.petType;
            }
        }


        public void CanHelp(IPetProblem problem)
        {
            throw new NotImplementedException(); // 
        }
    }
}
