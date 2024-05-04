namespace Societies.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRestaurantOrder
    {
        ICollection<IFood> Foods { get; set; }
        ICollection<IBeverage> Beverages { get; set; }
        public decimal TotalOrderPrice { get; set; }
    }
}
