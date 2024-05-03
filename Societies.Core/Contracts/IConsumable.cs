namespace Societies.Core.Contracts
{
    using Societies.Core.Infrastructure.Enumerations.Common;

    public interface IConsumable
    {
        BeverageType Type { get; set; }

        decimal TotalPrice { get; set; }
    }
}
