namespace GameObjects.Models.Abstract
{
    using Contracts;
    using GameObjects.Enumerations;

    public abstract class Trainer : Human, ITrainer
    {
        private const int TrainerBaseHp = 100;

        public Trainer(string name, TrainerType type)
            :base(name, TrainerBaseHp)
        {
            this.TrainerType = type;
        }


        public TrainerType TrainerType { get; protected set; }
    }
}
