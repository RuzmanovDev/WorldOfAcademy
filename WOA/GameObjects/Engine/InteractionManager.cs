namespace GameObjects.Engine
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Contracts;
    using Contracts.Engine;
    using Factories;
    using Enumerations;
    using Common.GlobalMessages;
    using Common.GlobalErrorMessages;
    using Common;

    public class InteractionManager : IInteractionManager
    {
        private readonly ICollection<ITrainer> trainers;
        private readonly ICollection<IStudent> students;

        private readonly IStudentFactory studentFactory;
        private readonly ITrainerFactory trainerFactory;
        private readonly IPetFactory petFactory;

        private readonly ILogger logger;
        private readonly IExamFactory examFactory = new ExamFactory();


        public InteractionManager(ILogger logger)
        {
            this.trainers = new HashSet<ITrainer>();
            this.students = new HashSet<IStudent>();

            this.studentFactory = new StudentFactory();
            this.trainerFactory = new TrainerFactory();
            this.petFactory = new PetFactory();

            this.logger = logger;

            GeneratePreviousYearTrainers();
        }


        public void AddTrainer(string name)
        {
            var exam = GenerateExam();

            this.trainers.Add(this.trainerFactory.CreateCurrentYearTrainer(name, exam));

            logger.WriteLine(GlobalMessages.TrainerWasAdded(name));
            //  this.trainerFactory.CreateTrainer(trainer);
        }

        public void AddStudent(string name)
        {
            IPet pet = this.petFactory.CreatePet();
            IStudent student = this.studentFactory.CreateStudent(name, pet);
            this.students.Add(student);

            student.CantPassExam += this.ExamFailsObserver;

            logger.WriteLine(GlobalMessages.StudentWasAded(name));
            //  logger.WriteLine(student.Pet.HelpMe(student)); // NE TUK!!!

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

        public void InvalidCommand()
        {
            this.logger.LogError(GlobalErrorMessages.InvalidCommand());
        }

        private IExam GenerateExam()
        {
            return this.examFactory.CreateExam();
        }

        public void StartExam(string trainerName)
        {
            ICurrentYearTrainer trainer = null;

            foreach (var tr in this.trainers)
            {
                if (tr.Name == trainerName)
                {
                    trainer = tr as ICurrentYearTrainer;
                }
            }

            if (trainer != null && trainer.IsAlive)
            {
                logger.WriteLine(GlobalMessages.TrainerThrowsExam(trainer.Name));
                var result = trainer.ThrowExam(this.students);

                logger.WriteLine(result);
            }
            else
            {
                logger.WriteLine($"There is no alive trainer with name {trainerName}");
            }
            
        }

        private void GeneratePreviousYearTrainers()
        {
            int trainersCount = RandomProvider.Instance.Next(3);

            for (int i = 0; i < trainersCount; i++)
            {
                var trainer = this.trainerFactory.CreatePreviousTrainer();
                this.trainers.Add(trainer);
            }
        }

        private string ExamFailsObserver(IKnowledge knowledge)
        {
            var result = new StringBuilder();

            this.trainers.Where(t => t.TrainerType == TrainerType.PreviousYears).ToList().ForEach(t => result.AppendLine(((IHelper)t).HelpMe(knowledge)));

            return result.ToString();
             }
    }
}

