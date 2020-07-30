// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace HomeBrewedPoker.Interfaces
{
    /// <summary>
    /// Interface that defines a hand of poker cards.
    /// </summary>
    public interface IHand
    {
        /// <summary>
        /// Defines the poker cards for the hand.
        /// </summary>
        IList<ICard> Cards { get; set; }
    }
}