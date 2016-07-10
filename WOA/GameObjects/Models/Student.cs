namespace GameObjects.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameObjects.Contracts;
    using GameObjects.Enumerations;
    using GameObjects.Models.Abstract;
    using GameObjects.Common;
    using GameObjects.Models.Stats;

    public class Student : Human, IStudent
    {
        private const int StudentBaseHp = 100;
        private const int StudentTypeKnowedgeBooseKoef = 5;
        private const int Baseknowledge = 10;

        private IKnowledge knowledge;
        private readonly StudentType studentType;
        private readonly OtherCompetence otherCompetence;
        private readonly IPet pet;
        public event Func<IKnowledge, string> CantPassExam;

        public Student(string name, IPet pet)
            : base(name, Student.StudentBaseHp)
        {
            // generate random number and cast it to enum
            int studentTypeRandGen = RandomProvider.Instance.Next(0, 2);

            this.studentType = (StudentType)studentTypeRandGen;
            this.Knowledge = GenerateInitialKnowedge(this.StudentType);
            this.otherCompetence = (OtherCompetence)RandomProvider.Instance.Next(0, 5);
            this.pet = pet;

        }

        private IKnowledge GenerateInitialKnowedge(StudentType studentType)
        {
            double initial = 0;
            if (studentType != StudentType.ThisYearStudent)
            {
                initial = 10;
            }
            initial = RandomProvider.Instance.Next(10, 21) + initial + (int)this.OtherCompetence;

            IKnowledge knowledge = new KnowledgeStats(initial);

            return knowledge;
        }



        public StudentType StudentType
        {
            get
            {
                return this.studentType;
            }
        }

        public OtherCompetence OtherCompetence
        {
            get
            {
                return otherCompetence;
            }
        }

        public IPet Pet
        {
            get
            {
                return this.pet;
            }
        }

        public IKnowledge Knowledge
        {
            get
            {
                return this.knowledge;
            }

            private set
            {
                this.knowledge = value;
            }
        }

        public string HandleExam(IExam exam)
        {
            // Call the pet to help or not
            var resultFromHandlingTheProblem = new StringBuilder();
            resultFromHandlingTheProblem.AppendLine(this.GetHelpFromPet());

            if (this.Knowledge.Knowledge > exam.Dificulty)
            {
                resultFromHandlingTheProblem.AppendLine($"{this.Name} has aced {exam}");
                // when the exam is tanked the student is restored to full HP
                this.HP = StudentBaseHp;
                return resultFromHandlingTheProblem.ToString();
            }


            resultFromHandlingTheProblem.AppendLine(OnExamFail(this.knowledge));
            if (this.Knowledge.Knowledge > exam.Dificulty)
            {
                resultFromHandlingTheProblem.AppendLine($"{this.Name} has aced at {exam}");
                // when the exam is tanked the student is restored to full HP
                this.HP = StudentBaseHp;
                return resultFromHandlingTheProblem.ToString();

            }


            int hpLost = (int)exam.Dificulty;
            this.HP -= hpLost;
            resultFromHandlingTheProblem.AppendLine($"{this.Name} failed at {exam}");
            resultFromHandlingTheProblem.AppendLine($"{this.Name} losses {hpLost}HP");
            resultFromHandlingTheProblem.AppendLine($"{this.Name} HP -> {this.HP}HP");


            return resultFromHandlingTheProblem.ToString();
        }



        public override string ToString()
        {
            return $"Student Name: {this.Name} HP: {this.HP} StudentType: {this.studentType} Competence: {this.OtherCompetence} Pet: {this.Pet} Knowledge: {this.Knowledge}";
        }

        public void ReceiveKnowledge(double knowledge)
        {
            this.Knowledge.AddKnowledge(knowledge);
        }

        public void ReceiveHP(int hp)
        {
            this.HP += hp;
        }

        private string GetHelpFromPet()
        {
            return this.Pet.HelpMe(this.Knowledge);
        }

        protected virtual string OnExamFail(IKnowledge knowledg)
        {
            Func<IKnowledge, string> handler = CantPassExam;
            if (handler != null)
            {
                return handler(knowledg);
            }

            return string.Empty;
        }
    }
}
