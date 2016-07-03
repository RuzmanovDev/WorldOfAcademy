namespace GameObjects.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Contracts;
    using Contracts.Engine;
    using Factories;
    using Enumerations;

    public class InteractionManager
    {
        private readonly ICollection<ITrainer> trainers;

        private readonly ICollection<IStudent> students;

        private readonly IStudentFactory studentFactory;
        private readonly ITrainerFactory trainerFactory;
        private readonly IAblityFactory abilityFactory;

        // private readonly IGameObjectManufacturerEngine gameObjectsFactory;


        public InteractionManager()
        {
            this.trainers = new List<ITrainer>();
            this.students = new List<IStudent>();
            this.studentFactory = new StudentFactory();
            this.trainerFactory = new TrainerFactory();
            this.abilityFactory = new AbilityFactory();
        }


        public void CreatTrainer(string name, TrainerType trainerType)
        {
            this.trainerFactory.CreateTrainer(name, 40, 40, null, trainerType);
            //  this.trainerFactory.CreateTrainer(trainer);
        }

    }
}
