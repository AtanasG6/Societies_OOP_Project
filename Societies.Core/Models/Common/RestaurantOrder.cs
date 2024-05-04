namespace Societies.Core.Models.Common
{
    using Societies.Core.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RestaurantOrder : IRestaurantOrder
    {
        public ICollection<IFood> Foods { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<IBeverage> Beverages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal TotalOrderPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
