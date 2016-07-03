using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameObjects.Contracts;
using GameObjects.Models.Abstract;

namespace GameObjects.Models
{
    public class Student : Human, IStudent
    {

        public Student(string name, int hp, int energy)
            : base(name, hp, energy)
        {
        }

        public IAbility ability
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void HandleProblem(IProblem problem)
        {
            throw new NotImplementedException();
        }
    }
}
