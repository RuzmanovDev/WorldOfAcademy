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

        public Student(string name)
            : base(name, 50, 100)
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
