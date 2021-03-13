// Copyright (c) Bruce Hunter Jr. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using HomeBrewedPoker.Interfaces;
using System;

namespace HomeBrewedPoker
{
    /// <summary>
    /// Represents a poker player.
    /// </summary>
    public class Player : IPlayer
    {
        /// <summary>
        /// Unique identifier for the player.
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// The poker hand for the player.
        /// </summary>
        public IHand Hand { get; set; }

        /// <summary>
        /// Poker Player Constructor
        /// </summary>
        /// <param name="id">Poker player identifier.</param>
        /// <param name="hand">Poker player poker hand.</param>
        public Player(Guid id, IHand hand)
        {
            ID = id;
            Hand = hand;
        }
    }
}