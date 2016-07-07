namespace GameObjects.Contracts
{
    using GameObjects.Enumerations;

    public interface IPet
    {
         
            PetType PetType { get; }

            void CanHelp(IPetProblem problem);

    }
}
