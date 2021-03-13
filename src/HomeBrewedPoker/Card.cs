// Copyright (c) Bruce Hunter Jr. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using HomeBrewedPoker.Interfaces;
using System;

namespace HomeBrewedPoker
{
    /// <summary>
    /// Represents a single card within a standard 52-card poker deck.
    /// </summary>
    public class Card : ICard
    {      
        /// <summary>
        /// The card type for the current card instance.
        /// </summary>
        public virtual CardType Type { get; set; }

        /// <summary>
        /// Card constructor.
        /// </summary>
        /// <param name="cardType">The card type.</param>
        public Card(CardType cardType)
        {
            Type = cardType;
        }

        /// <summary>
        /// Get the rank for the current card instance.
        /// </summary>
        /// <returns>A <see cref="T:HomeBrewedPoker.RankType"/></returns>
        public virtual RankType GetRank()
        {
            //TODO: implement a cleaner way todo this logic.

            var name = Enum.GetName(typeof(CardType), Type);           

            if (name.Contains(Enum.GetName(typeof(RankType), 1)))
            {
                return RankType.Ace;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 2)))
            {
                return RankType.Two;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 3)))
            {
                return RankType.Three;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 4)))
            {
                return RankType.Four;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 5)))
            {
                return RankType.Five;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 6)))
            {
                return RankType.Six;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 7)))
            {
                return RankType.Seven;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 8)))
            {
                return RankType.Eight;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 9)))
            {
                return RankType.Nine;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 10)))
            {
                return RankType.Ten;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 11)))
            {
                return RankType.Jack;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 12)))
            {
                return RankType.Queen;
            }

            if (name.Contains(Enum.GetName(typeof(RankType), 13)))
            {
                return RankType.King;
            }

            throw new Exception("Unable to determine card rank type.");
        }

        /// <summary>
        /// Get the suit for the current card type instance.
        /// </summary>
        /// <returns>A <see cref="T:HomeBrewedPoker.SuitType"/></returns>
        public virtual SuitType GetSuit()
        {
            var name = Enum.GetName(typeof(CardType), Type);

            if (name.Contains(Enum.GetName(typeof(SuitType), 1)))
            {
                return SuitType.Clubs;
            }

            if (name.Contains(Enum.GetName(typeof(SuitType), 2)))
            {
                return SuitType.Diamonds;
            }

            if (name.Contains(Enum.GetName(typeof(SuitType), 3)))
            {
                return SuitType.Hearts;
            }

            if (name.Contains(Enum.GetName(typeof(SuitType), 4)))
            {
                return SuitType.Spades;
            }

            throw new Exception("Unable to determine card suit type.");
        }
    }
}