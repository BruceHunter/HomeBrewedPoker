// Copyright (c) Bruce Hunter Jr. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;

namespace HomeBrewedPoker.Interfaces
{
    /// <summary>
    /// Interface that defines a poker card.
    /// </summary>
    public interface ICard : IEquatable<ICard>, IComparable<ICard>
    {
        /// <summary>
        /// The card type for the current card instance.
        /// </summary>
        CardType Type { get; }
        /// <summary>
        /// Get the rank for the current card instance.
        /// </summary>
        /// <returns>A <see cref="T:HomeBrewedPoker.Card.RankType"/></returns>
        RankType GetRank();
        /// <summary>
        /// Get the suit for the current card instance.
        /// </summary>
        /// <returns>A <see cref="T:HomeBrewedPoker.Card.Suit"/></returns>
        SuitType GetSuit();
    }
}