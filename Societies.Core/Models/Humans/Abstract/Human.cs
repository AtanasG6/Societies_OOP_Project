namespace Societies.Core.Models.Humans.Abstarct
{
    using Societies.Core.Contracts;
    using Societies.Core.Infrastructure.Enumerations.Human;
    using Societies.Core.Infrastructure.Utils;
    using Societies.Core.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human : IHuman
    {
        private readonly string name;
        private readonly int age;
        private readonly HairColorType hairColor;
        private readonly EyesColorType eyesColor;
        private readonly FaceShapeType faceShape;
        private readonly RaceType race;
        private readonly GenderType gender;
        private readonly ReligionType religion;

        protected Human(
            string name,
            int age,
            HairColorType hairColor,
            EyesColorType eyesColor,
            FaceShapeType faceShape,
            RaceType race,
            GenderType gender,
            ReligionType religion
            )
        {
            this.Id = DataGenerator.GenerateUniqueId();
            this.Name = name;
        }


        public GenderType Gender { get; set; }
        public ReligionType Religion { get; set; }
        public RaceType Race { get; set; }
        public HairColorType HairColor { get; set; }
        public EyesColorType EyesColor { get; set; }
        public FaceShapeType FaceShape { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal MoneyInEuro { get; set; }
        public int StarvationLevel { get; set; }
        public int VitalityLevel { get; set; }
        public int ThirstLevel { get; set; }

        public void Drink(Beverage beverage)
        {
            throw new NotImplementedException();
        }

        public void Eat(Food food)
        {
            throw new NotImplementedException();
        }

        public virtual decimal Pay(decimal amountToBePaid)
        {
            throw new NotImplementedException();
        }

        public void Rest(int minutes)
        {
            throw new NotImplementedException();
        }

        public void Sleep(int hours)
        {
            throw new NotImplementedException();
        }

        public void Work(int hours)
        {
            throw new NotImplementedException();
        }
    }
}
