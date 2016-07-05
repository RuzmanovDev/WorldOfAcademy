namespace GameObjects.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;

    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Exam : IExam
    {
        // Icollection<Iproblem>
        /// name
        /// 
        public int Dificulty
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<IProblem> ProgblemsList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void GiveKnowledge(IStudent st)
        {
            throw new NotImplementedException();
        }
    }
}
