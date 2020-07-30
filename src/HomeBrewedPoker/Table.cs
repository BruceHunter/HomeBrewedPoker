// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using HomeBrewedPoker.Interfaces;
using System;
using System.Collections.Generic;

namespace HomeBrewedPoker
{
    /// <summary>
    /// Represents a poker table.
    /// </summary>
    public class Table : ITable
    {
        /// <summary>
        /// Unique identifier for the table.
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// The poker dealer for the table.
        /// </summary>
        public IDealer Dealer { get; set; }
        /// <summary>
        /// The poker players for the table.
        /// </summary>
        public IList<IPlayer> Players { get; set; }

        /// <summary>
        /// Poker Table Constructor.
        /// </summary>
        /// <param name="id">Poker table identifier.</param>
        /// <param name="dealer">Poker table dealer.</param>
        /// <param name="players">Poker table players.</param>
        public Table(Guid id, IDealer dealer, IList<IPlayer> players)
        {
            ID = id;
            Dealer = dealer;
            Players = players;
        }
    }
}