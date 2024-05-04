namespace Societies.Core.Models.Humans
{
    using Societies.Core.Infrastructure.Enumerations.Human;
    using Societies.Core.Models.Humans.Abstarct;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Waiter : Human
    {
        public Waiter(
            string name, 
            int age, 
            HairColorType hairColor, 
            EyesColorType eyesColor, 
            FaceShapeType faceShape, 
            RaceType race, GenderType gender,
            ReligionType religion) 
            : base(name, age, hairColor, eyesColor, faceShape, race, gender, religion)
        {
        }
    }
}
