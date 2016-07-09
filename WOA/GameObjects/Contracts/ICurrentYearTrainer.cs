using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Contracts
{
    interface ICurrentYearTrainer : ITrainer, IHuman
    {
        IExam Exam { get; }

        string ThrowExam(IEnumerable<IStudent> st);
    }
}
