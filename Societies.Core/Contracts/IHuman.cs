namespace Societies.Core.Contracts
{
    using Societies.Core.Infrastructure.Enumerations.Human;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IHuman
    {
        int Id { get; set; }

        string Name { get; set; }

        int Age { get; set; }

        GenderType Gender { get; set; }

        ReligionType Religion { get; set; }
        
        RaceType Race { get; set; }

        HairColorType HairColor { get; set; }

        EyesColorType EyesColor { get; set; }

        FaceShapeType FaceShape { get; set; }

        decimal MoneyInEuro { get; set; }

        void Eat();
    }
}
