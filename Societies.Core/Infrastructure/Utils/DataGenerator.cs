namespace Societies.Core.Infrastructure.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DataGenerator
    {
        private static int counter;
        private static string[] maleNames;
        private static string[] femaleNames;
        private static Random random;

        static DataGenerator()
        {
            counter = 0;
            maleNames = new string[]
            {
                "Gosho",
                "Tosho",
                "Pesho",
                "Bobi",
                "Vanio"
            };

            femaleNames = new string[]
           {
                "Victoria",
                "Veronica",
                "Angelina",
                "Mariela",
                "Mariyana"
           };

            random = new Random();
        }

        public static int GenerateUniqueId()
        {
            //thread safe
            return Interlocked.Increment(ref counter);
            
        }

        public static string GenerateMaleName()
        {
            var index = random.Next(0, maleNames.Length);
            return maleNames[index];
        }

        public static string GenerateFemaleName()
        {
            var index = random.Next(0, maleNames.Length);
            return femaleNames[index];
        }

        public static int GenerateAge()
        {
            return random.Next(15, 41);
        }
    }
}
