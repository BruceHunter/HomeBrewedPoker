// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using HomeBrewedPoker.Interfaces;
using System.Collections.Generic;

namespace HomeBrewedPoker
{
    /// <summary>
    /// Represents a hand of poker cards.
    /// </summary>
    public class Hand: IHand
    {
        /// <summary>
        /// Poker cards for the hand.
        /// </summary>
        public IList<ICard> Cards { get; set; }

        /// <summary>
        /// Poker Hand Constructor
        /// </summary>
        /// <param name="cards">Poker Cards.</param>
        public Hand(IList<ICard> cards)
        {
            Cards = cards;
        }
    }
}
