namespace Societies.Core.Models.Humans.Abstarct
{
    using Societies.Core.Contracts;
    using Societies.Core.Infrastructure.Constants;
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
        private int vitalityLevel;
        private int thirstLevel;
        private int starvationLevel;
        private decimal moneyInEuro;

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
            this.Age = age;
            this.HairColor = hairColor;
            this.FaceShape = faceShape;
            this.EyesColor = eyesColor;
            this.Religion = religion;
            this.Gender = gender;
            this.Race = race;  
        }


        public GenderType Gender { get; }
        public ReligionType Religion { get; }
        public RaceType Race { get; }
        public HairColorType HairColor { get;  }
        public EyesColorType EyesColor { get; }
        public FaceShapeType FaceShape { get; }

        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public decimal MoneyInEuro { get; }
        public int StarvationLevel { get; }
        public int VitalityLevel { get; }
        public int ThirstLevel { get; }

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

        public override string ToString()
        {
            var builder = new StringBuilder(500);

            builder.AppendLine(new string('=', GlobalConstants.DelimiterCount));
            builder.AppendLine($"Id: {this.Id}");
            builder.AppendLine($"Name: {this.name}");
            builder.AppendLine($"Age: {this.age}");
            builder.AppendLine($"Vitality level: {this.vitalityLevel}/{ValidationConstants.VitalityLevelMaxValue}");
            builder.AppendLine($"Starvation level: {this.starvationLevel}/{ValidationConstants.StarvationLevelMaxValue}");
            builder.AppendLine($"Thirst level: {this.thirstLevel}/{ValidationConstants.ThirstLevelMaxValue}");
            builder.AppendLine($"Race: {this.race}");
            builder.AppendLine($"Gender: {this.gender}");
            builder.AppendLine($"Religion: {this.religion}");
            builder.AppendLine($"Face shape: {this.faceShape}");
            builder.AppendLine($"Eyes color: {this.eyesColor}");
            builder.AppendLine($"Hair color: {this.hairColor}");
            builder.AppendLine($"Money in euro: {(char)8364}{this.moneyInEuro}");
            builder.AppendLine(new string('=', GlobalConstants.DelimiterCount));

            return builder.ToString();
        }
    }
}
