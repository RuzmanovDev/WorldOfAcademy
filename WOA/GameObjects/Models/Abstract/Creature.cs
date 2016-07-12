namespace GameObjects.Models.Abstract
{
    using Contracts;
    using Common;

    public abstract class Creature : ICreature
    {
        private string name;

        public Creature(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                this.name = value;
            }
        }
    }
}
