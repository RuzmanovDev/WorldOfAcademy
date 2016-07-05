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
    using Common.GlobalMessages;    // does most of the work maybe split it to smaller classes 
    public class InteractionManager : IInteractionManager
    {
        private readonly ICollection<ITrainer> trainers;

        private readonly ICollection<IStudent> students;

        private readonly IStudentFactory studentFactory;
        private readonly ITrainerFactory trainerFactory;
        private readonly IAblityFactory abilityFactory;


        private readonly ILogger logger;

        // private readonly IGameObjectManufacturerEngine gameObjectsFactory;


        public InteractionManager(ILogger logger)
        {
            this.trainers = new List<ITrainer>();
            this.students = new List<IStudent>();

            this.studentFactory = new StudentFactory();
            this.trainerFactory = new TrainerFactory();
            this.abilityFactory = new AbilityFactory();

            this.logger = logger;
        }


        public void AddTrainer(string name, TrainerType trainerType)
        {
            this.trainers.Add(this.trainerFactory.CreateTrainer(name, 40, 40, null, trainerType));

            logger.WriteLine($"--Trainer {name} was added");
            //  this.trainerFactory.CreateTrainer(trainer);
        }

        public void AddStudent(string name)
        {
            this.students.Add(this.studentFactory.CreateStudent(name));

            logger.WriteLine(GlobalMessages.StudentWasAded(name));

        }

        public void PrintStatus(string name)
        {
            foreach (var student in this.students)
            {
                if (student.Name == name)
                {
                    this.logger.WriteLine(student.ToString());
                    return;
                }
            }

            foreach (var trainer in this.trainers)
            {
                if (trainer.Name == name)
                {
                    this.logger.WriteLine(trainer.ToString());
                    return;
                }
            }
        }
    }
}
