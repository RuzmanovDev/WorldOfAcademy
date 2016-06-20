using System;
using Assets.Contracts;

namespace Assets.Characters
{
    public abstract class Unit : IUnit, IFraction
    {
        public int AttackPoints
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int DefensePoints
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int EnergyPoints
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public FractionType Fraction
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int HealthPoints
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Range
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
