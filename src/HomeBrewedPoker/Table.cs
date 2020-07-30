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
        public Guid ID { get; set; }
        public IDealer Dealer { get; set; }
        public IList<IPlayer> Players { get; set; }

        public Table(Guid id, IDealer dealer, IList<IPlayer> players)
        {
            ID = id;
            Dealer = dealer;
            Players = players;
        }
    }
}