using GameObjects.Contracts;
using GameObjects.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Models.Pets
{
    public class Dog : Pet, IPet
    {
        public Dog(string name) : base(name)
        {
        }

        public override string CanHelp()
        {
            // kucheto poiska da se razhodi -nqkakav knowedge
            throw new NotImplementedException();
        }
    }
}
