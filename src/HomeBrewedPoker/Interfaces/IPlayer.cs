// Copyright (c) Bruce Hunter Jr. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;

namespace HomeBrewedPoker.Interfaces
{
    /// <summary>
    /// Interface that defines a poker player.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Defines unique identifier for the player.
        /// </summary>
        Guid ID { get; set; }
        /// <summary>
        /// Defines the poker hand for the player.
        /// </summary>
        IHand Hand { get; set; }
    }
}