namespace GameObjects.Common.GlobalMessages
{
    public static class GlobalMessages
    {
        public static string StudentWasAded(string name)
        {
            return $"--Student {name} was successfully created";
        }

        public static string TrainerWasAdded(string name)
        {
            return $"--Trainer {name} was successfully created";
        }

        public static string TrainerThrowsExam(string name)
        {
            return $"--Trainer {name} gives exam to students";
        }
    }
}
