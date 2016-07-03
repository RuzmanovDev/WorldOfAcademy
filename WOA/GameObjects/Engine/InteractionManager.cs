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
    // does most of the work maybe split it to smaller classes 
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


        public void AddTrainer(string name, TrainerType trainerType)
        {
            this.trainers.Add(this.trainerFactory.CreateTrainer(name, 40, 40, null, trainerType));
            //  this.trainerFactory.CreateTrainer(trainer);
        }

        public void AddStudent(string name)
        {
            this.students.Add(this.studentFactory.CreateStudent(name));
        }

    }
}
