// Copyright (c) Bruce Hunter Jr. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace HomeBrewedPoker.Types
{
    /// <summary>
    /// Represents a standard 52-card deck rank.
    /// </summary>
    public enum HandRankType
    {
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        /// <remarks>
        /// Only possible when using one or more wild cards
        /// </remarks>
        FiveOfAKind = 1,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        /// <remarks>
        /// Category does not exist under ace-to-five low rules
        /// </remarks>
        StraightFlush = 2,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        FourOfAKind = 3,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        FullHouse = 4,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        /// <remarks>
        /// Category does not exist under ace-to-five low rules
        /// </remarks>
        Flush = 5,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        /// <remarks>
        /// Category does not exist under ace-to-five low rules
        /// </remarks>
        Straight = 6,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        ThreeOfAKind = 7,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        TwoPair = 8,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        OnePair = 9,
        /// <summary>
        /// Represents the card rank Ace.
        /// </summary>
        HighCard = 10,
    }
}
