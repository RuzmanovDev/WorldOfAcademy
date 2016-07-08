using GameObjects.Contracts;
using GameObjects.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Models.Pets
{
    public class Cat : Pet, IPet
    {
        public Cat(string name) : base(name)
        {
        }

        public override string CanHelp()
        {
            // kotkata izqde domashnoto --
            throw new NotImplementedException();
        }
    }
}
