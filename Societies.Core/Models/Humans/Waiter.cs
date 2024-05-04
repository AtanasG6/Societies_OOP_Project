namespace Societies.Core.Models.Humans
{
    using Societies.Core.Contracts;
    using Societies.Core.Infrastructure.Enumerations.Human;
    using Societies.Core.Models.Humans.Abstarct;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Waiter : Human, IWaiter
    {
        private decimal tips;
        private Dictionary<IHuman, IRestaurantOrder> orders;
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
            this.orders = new Dictionary<IHuman, IRestaurantOrder>();
        }

        public decimal Tips
        {
            get
            {
                return this.tips;
            }
            set
            {
                this.tips = value;
            }
        }

        public void GetOrder(IRestaurantOrder order, IHuman client)
        {
            this.orders.Add(client, order);
        }

        public void ServeOrder(IHuman client)
        {
            var clientOrder = this.orders[client];

            client.Eat(clientOrder.Foods);
        }

        public void RequestPayment(IHuman client)
        {
            throw new NotImplementedException();
        }

    }
}
