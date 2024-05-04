namespace Societies.Core.Contracts
{
    using Societies.Core.Infrastructure.Enumerations.Human;
    using Societies.Core.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IHuman
    {
        int Id { get; }
        string Name { get; }
        int Age { get; }
        GenderType Gender { get; }
        ReligionType Religion { get; }        
        RaceType Race { get;  }
        HairColorType HairColor { get; }
        EyesColorType EyesColor { get; }
        FaceShapeType FaceShape { get; }
        decimal MoneyInEuro { get; }
        int VitalityLevel { get; }
        int StarvationLevel { get; }
        int ThirstLevel {  get; }

        void Eat(ICollection<IFood> food);
        void Drink(ICollection<IBeverage> beverage);
        void Work(int hours);
        void Sleep(int hours);
        void Rest(int minutes);
        decimal Pay(decimal amountToBePaid);
    }
}
