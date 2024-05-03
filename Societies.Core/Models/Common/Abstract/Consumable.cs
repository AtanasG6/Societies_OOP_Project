namespace Societies.Core.Models.Common.Abstract
{
    using Societies.Core.Contracts;
    using Societies.Core.Infrastructure.Enumerations.Common;
    using Societies.Core.Infrastructure.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Consumable : IConsumable
    {
        private decimal _totalPrice;
        public decimal TotalPrice 
        {
            get
            {
                return this._totalPrice;
            }
            set
            {
                if (value < 0)
                {
                    throw new PriceOutOfRangeException(
                        "Price was not in the desired range [0;infinity]",
                        value);
                }

                this._totalPrice = value;
            }
        }
        public BeverageType Type { get; set; }
    }
}
