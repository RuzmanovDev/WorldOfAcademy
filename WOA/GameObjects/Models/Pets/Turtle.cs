using GameObjects.Contracts;
using GameObjects.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Models.Pets
{
    public class Turtle : Pet, IPet
    {
        private const int KnowledgeBoost = 15;

        public Turtle(string name) : base(name)
        {
        }
      
        public override string HelpMe(IStudent student)
        {
            student.ReceiveKnowledge(Turtle.KnowledgeBoost);

            return $"{this.ToString()} gives the student it's wisdom!!! The student receives {Turtle.KnowledgeBoost} knowledge!";
        }
    }
}
