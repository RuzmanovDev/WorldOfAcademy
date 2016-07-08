using GameObjects.Contracts;
using GameObjects.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Models.Pets
{
    public class GoldFish : Pet, IPet
    {
        private const int KnowledgeBoost = 10;

        public GoldFish(string name) : base(name)
        {
        }

        public override string HelpMe(IStudent student)
        {
            student.ReceiveKnowledge(GoldFish.KnowledgeBoost);

            return $"{this.ToString()} blessed the student! The student receives {GoldFish.KnowledgeBoost} knowledge!"; 
        }
    }
}
