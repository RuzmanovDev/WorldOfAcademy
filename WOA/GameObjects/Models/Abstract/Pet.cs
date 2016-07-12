namespace GameObjects.Models.Abstract
{
    using GameObjects.Contracts;

    public abstract class Pet : Creature, IPet
    {

        public Pet(string name)
                : base(name)
        {
        }

        public abstract string HelpMe(IKnowledge knowledge);

        public override string ToString()
        {
            return $"Pet: {this.GetType().Name} {this.Name}";
        }
    }
}
