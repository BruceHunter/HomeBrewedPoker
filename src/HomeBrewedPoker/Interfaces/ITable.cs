// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;

namespace HomeBrewedPoker.Interfaces
{
    /// <summary>
    /// Interface that defines a poker table.
    /// </summary>
    public interface ITable
    {
        /// <summary>
        /// Defines unique identifier for the table.
        /// </summary>
        Guid ID { get; set; }
        /// <summary>
        /// Defines a poker dealer for the table.
        /// </summary>
        IDealer Dealer { get; set; }
        /// <summary>
        /// Defines the poker players for the table.
        /// </summary>
        IList<IPlayer> Players { get; set; }
    }
}