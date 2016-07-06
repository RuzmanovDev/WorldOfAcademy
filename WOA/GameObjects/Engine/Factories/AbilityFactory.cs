namespace GameObjects.Engine.Factories
{
    using System;

    using GameObjects.Contracts;
    using GameObjects.Contracts.Engine;
    using System.Globalization;

    public class AbilityFactory : IAblityFactory
    {
        public IAbility CreateAbility(string name)
        {
            switch (name)
            {
                
                default:
                    throw new ArgumentException(
                        string.Format(CultureInfo.InvariantCulture, "Invalid creature type \"{0}\"!", name));
            }
        }
    }
}
