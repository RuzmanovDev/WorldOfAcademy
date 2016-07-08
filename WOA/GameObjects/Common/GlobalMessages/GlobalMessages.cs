namespace GameObjects.Common.GlobalMessages
{
using GameObjects.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public static string PetHelps(IPet pet)
        //{
        //    return $"-- {pet.ToString()}";
        //}
    }
}
