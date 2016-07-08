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
        private const int KnowledgeBoost = -5;

        public Cat(string name) : base(name)
        {
        }

        public override string HelpMe(IStudent student)
        {
            student.ReceiveKnowledge(Cat.KnowledgeBoost);

            return $"{this.ToString()} ate the homework!! The student receives {Cat.KnowledgeBoost} knowledge!!";
        }
    }
}
