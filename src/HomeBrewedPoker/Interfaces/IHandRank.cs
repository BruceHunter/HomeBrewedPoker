// Copyright (c) Bruce Hunter Jr. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using HomeBrewedPoker.Types;

namespace HomeBrewedPoker.Interfaces
{
    /// <summary>
    /// Interface that defines a poker card.
    /// </summary>
    public interface IHandRank
    {
        /// <summary>
        /// Get the rank for the current card instance.
        /// </summary>
        /// <returns>A <see cref="T:HomeBrewedPoker.Card.RankType"/></returns>
        HandRankType? GetHandRank(IHand hand);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        bool HasStraightFlush(IHand hand);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        bool HasStraight(IHand hand);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        bool HasFlush(IHand hand);
    }
}