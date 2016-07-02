namespace GameObjects.Engine.Factories
{
    using System;

    using GameObjects.Contracts;
    using GameObjects.Contracts.Engine;
    using Models.Abilities;
    using System.Globalization;

    public class AbilityFactory : IAblityFactory
    {
        public IAbility CreateAbility(string name)
        {
            switch (name)
            {
                case "Engineer":
                    return new Engineer();
                case "ITCompetitionChampion":
                    return new ITCompetitionChampion();
                case "Mathematician":
                    return new Mathematician();
                case "PastYearStudent":
                    return new PastYearStudent();
                default:
                    throw new ArgumentException(
                        string.Format(CultureInfo.InvariantCulture, "Invalid creature type \"{0}\"!", name));
            }
        }
    }
}
