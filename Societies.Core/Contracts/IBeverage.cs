﻿namespace Societies.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBeverage : IConsumable
    {
        int PortionSizeInMilliliters { get; set; }

    }
}
