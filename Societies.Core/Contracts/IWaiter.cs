namespace Societies.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IWaiter
    {
        decimal Tips { get; set; }
        void GetOrder(IRestaurantOrder order, IHuman cleint);
        void ServeOrder(IHuman cleint);
        void RequestPayment(IHuman client);
    }
}
