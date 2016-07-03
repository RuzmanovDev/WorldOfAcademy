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

        private IStudentFactory studentFactory;
        private ITrainerFactory trainerFactory;
        private IAblityFactory abilityFactory;

        // private readonly IGameObjectManufacturerEngine gameObjectsFactory;


        public InteractionManager()
        {
            this.trainers = new List<ITrainer>();
            this.students = new List<IStudent>();
        }


        public void CreatTrainer(string trianer)
        {
          //  this.trainerFactory.CreateTrainer(trainer);
        }
        
    }
}
