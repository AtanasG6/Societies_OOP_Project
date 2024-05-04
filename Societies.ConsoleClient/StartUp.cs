namespace Societies.ConsoleClient
{
    using Societies.Core.Contracts;
    using Societies.Core.Infrastructure.Enumerations.Human;
    using Societies.Core.Models.Humans;
    using Societies.Core.Models.Humans.Abstarct;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        static void Main()
        {
            var human = new Waiter(
                "Gosho",
                21,
                HairColorType.Blue,
                EyesColorType.Brown,
                FaceShapeType.Heart,
                RaceType.European,
                GenderType.Male,
                ReligionType.Hinduism
                );

            Console.WriteLine(human);

        }
    }
}
