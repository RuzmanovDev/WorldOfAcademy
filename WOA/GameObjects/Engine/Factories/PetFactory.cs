namespace GameObjects.Engine.Factories
{
    using GameObjects.Contracts.Engine;
    using GameObjects.Contracts;
    using GameObjects.Common;
    using GameObjects.Models.Pets;

    public class PetFactory : IPetFactory
    {
        private int NumberOfPetsSoFar = 4;
        public IPet CreatePet()
        {
            string petName = GeneratePetName();
            IPet pet = GeneratePetType(petName);

            return pet;
        }

        private IPet GeneratePetType(string petName)
        {
            int random = RandomProvider.Instance.Next(1, NumberOfPetsSoFar + 1);
            switch (random)
            {
                case 1: return new Cat(petName);
                case 2: return new Dog(petName);
                case 3: return new GoldFish(petName);
                case 4: return new Turtle(petName);
                default: throw new InternalGameException("There is no such pet");
            }
        }

        private string GeneratePetName()
        {
            string petName = string.Empty;
            string[] petNames = {"Sharo", "Mqu", "IEnumerable", "MasterOfAlgorithms", "Balkan", "Jaime", "Your worst nightmare",
            "Otpada-script", "Bye-bye","Malko-Kote", "ValeriB", "BB", "Koce" , "Cuki" , "Viktor", "Nakov", "Ivo", "LinuxLover",
            "Mqu-mqu-JS"};

            petName = petNames[RandomProvider.Instance.Next(0, petName.Length)];
            return petName;
        }
    }
}