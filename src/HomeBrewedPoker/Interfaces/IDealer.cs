// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace HomeBrewedPoker.Interfaces
{
    /// <summary>
    /// Interface that defines a single poker dealer.
    /// </summary>
    public interface IDealer : ICardShuffler
    {
        /// <summary>
        /// Defines the deck of card the dealer is holding.
        /// </summary>
        IEnumerable<ICard> CardDeck { get; }
    }
}