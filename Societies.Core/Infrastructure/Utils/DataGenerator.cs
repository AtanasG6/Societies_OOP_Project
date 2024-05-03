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

        static DataGenerator()
        {
            counter = 1;
        }

        public static int GenerateUniqueId()
        {
            //thread safe
            return Interlocked.Increment(ref counter);
            
        }
    }
}
