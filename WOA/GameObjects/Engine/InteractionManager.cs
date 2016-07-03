namespace GameObjects.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Contracts;
    using Contracts.Engine;

    public class InteractionManager
    {
        private readonly ICollection<ITrainer> trainers;

        private readonly ICollection<IStudent> students;

        private readonly IGameObjectManufacturerEngine gameObjectsFactory;

        public InteractionManager(ICollection<ITrainer> trainers,ICollection<IStudent> students)
        {
            this.trainers = trainers;
            this.students = students;
        }

    }
}
