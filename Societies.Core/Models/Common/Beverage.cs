namespace Societies.Core.Models.Common
{
    using Societies.Core.Contracts;
    using Societies.Core.Infrastructure.Enumerations.Common;
    using Societies.Core.Models.Common.Abstract;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Beverage : Consumable, IBeverage
    {
        public int PortionSizeInMilliliters { get; set; }
    }
}
