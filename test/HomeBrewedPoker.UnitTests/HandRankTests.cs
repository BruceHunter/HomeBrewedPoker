// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using FluentAssertions;
using HomeBrewedPoker.Interfaces;
using HomeBrewedPoker.Types;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace HomeBrewedPoker.UnitTests
{
    /// <summary>
    /// All possible straight flush hands.
    /// </summary>
    public class StraightFlushDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            //Clubs
            new object[] {new Hand(new List<ICard>() { new Card(CardType.AceOfClubs), new Card(CardType.KingOfClubs), new Card(CardType.QueenOfClubs), new Card(CardType.JackOfClubs), new Card(CardType.TenOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.KingOfClubs), new Card(CardType.QueenOfClubs), new Card(CardType.JackOfClubs), new Card(CardType.TenOfClubs), new Card(CardType.NineOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.QueenOfClubs), new Card(CardType.JackOfClubs), new Card(CardType.TenOfClubs), new Card(CardType.NineOfClubs), new Card(CardType.EightOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.JackOfClubs), new Card(CardType.TenOfClubs), new Card(CardType.NineOfClubs), new Card(CardType.EightOfClubs), new Card(CardType.SevenOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.TenOfClubs), new Card(CardType.NineOfClubs), new Card(CardType.EightOfClubs), new Card(CardType.SevenOfClubs), new Card(CardType.SixOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.NineOfClubs), new Card(CardType.EightOfClubs), new Card(CardType.SevenOfClubs), new Card(CardType.SixOfClubs), new Card(CardType.FiveOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.EightOfClubs), new Card(CardType.SevenOfClubs), new Card(CardType.SixOfClubs), new Card(CardType.FiveOfClubs), new Card(CardType.FourOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.SevenOfClubs), new Card(CardType.SixOfClubs), new Card(CardType.FiveOfClubs), new Card(CardType.FourOfClubs), new Card(CardType.ThreeOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.SixOfClubs), new Card(CardType.FiveOfClubs), new Card(CardType.FourOfClubs), new Card(CardType.ThreeOfClubs), new Card(CardType.TwoOfClubs) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.FiveOfClubs), new Card(CardType.FourOfClubs), new Card(CardType.ThreeOfClubs), new Card(CardType.TwoOfClubs), new Card(CardType.AceOfClubs) })},

            //Diamonds
            new object[] {new Hand(new List<ICard>() { new Card(CardType.AceOfDiamonds), new Card(CardType.KingOfDiamonds), new Card(CardType.QueenOfDiamonds), new Card(CardType.JackOfDiamonds), new Card(CardType.TenOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.KingOfDiamonds), new Card(CardType.QueenOfDiamonds), new Card(CardType.JackOfDiamonds), new Card(CardType.TenOfDiamonds), new Card(CardType.NineOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.QueenOfDiamonds), new Card(CardType.JackOfDiamonds), new Card(CardType.TenOfDiamonds), new Card(CardType.NineOfDiamonds), new Card(CardType.EightOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.JackOfDiamonds), new Card(CardType.TenOfDiamonds), new Card(CardType.NineOfDiamonds), new Card(CardType.EightOfDiamonds), new Card(CardType.SevenOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.TenOfDiamonds), new Card(CardType.NineOfDiamonds), new Card(CardType.EightOfDiamonds), new Card(CardType.SevenOfDiamonds), new Card(CardType.SixOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.NineOfDiamonds), new Card(CardType.EightOfDiamonds), new Card(CardType.SevenOfDiamonds), new Card(CardType.SixOfDiamonds), new Card(CardType.FiveOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.EightOfDiamonds), new Card(CardType.SevenOfDiamonds), new Card(CardType.SixOfDiamonds), new Card(CardType.FiveOfDiamonds), new Card(CardType.FourOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.SevenOfDiamonds), new Card(CardType.SixOfDiamonds), new Card(CardType.FiveOfDiamonds), new Card(CardType.FourOfDiamonds), new Card(CardType.ThreeOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.SixOfDiamonds), new Card(CardType.FiveOfDiamonds), new Card(CardType.FourOfDiamonds), new Card(CardType.ThreeOfDiamonds), new Card(CardType.TwoOfDiamonds) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.FiveOfDiamonds), new Card(CardType.FourOfDiamonds), new Card(CardType.ThreeOfDiamonds), new Card(CardType.TwoOfDiamonds), new Card(CardType.AceOfDiamonds) })},

            //Hearts
            new object[] {new Hand(new List<ICard>() { new Card(CardType.AceOfHearts), new Card(CardType.KingOfHearts), new Card(CardType.QueenOfHearts), new Card(CardType.JackOfHearts), new Card(CardType.TenOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.KingOfHearts), new Card(CardType.QueenOfHearts), new Card(CardType.JackOfHearts), new Card(CardType.TenOfHearts), new Card(CardType.NineOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.QueenOfHearts), new Card(CardType.JackOfHearts), new Card(CardType.TenOfHearts), new Card(CardType.NineOfHearts), new Card(CardType.EightOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.JackOfHearts), new Card(CardType.TenOfHearts), new Card(CardType.NineOfHearts), new Card(CardType.EightOfHearts), new Card(CardType.SevenOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.TenOfHearts), new Card(CardType.NineOfHearts), new Card(CardType.EightOfHearts), new Card(CardType.SevenOfHearts), new Card(CardType.SixOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.NineOfHearts), new Card(CardType.EightOfHearts), new Card(CardType.SevenOfHearts), new Card(CardType.SixOfHearts), new Card(CardType.FiveOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.EightOfHearts), new Card(CardType.SevenOfHearts), new Card(CardType.SixOfHearts), new Card(CardType.FiveOfHearts), new Card(CardType.FourOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.SevenOfHearts), new Card(CardType.SixOfHearts), new Card(CardType.FiveOfHearts), new Card(CardType.FourOfHearts), new Card(CardType.ThreeOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.SixOfHearts), new Card(CardType.FiveOfHearts), new Card(CardType.FourOfHearts), new Card(CardType.ThreeOfHearts), new Card(CardType.TwoOfHearts) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.FiveOfHearts), new Card(CardType.FourOfHearts), new Card(CardType.ThreeOfHearts), new Card(CardType.TwoOfHearts), new Card(CardType.AceOfHearts) })},

            //Spades
            new object[] {new Hand(new List<ICard>() { new Card(CardType.AceOfSpades), new Card(CardType.KingOfSpades), new Card(CardType.QueenOfSpades), new Card(CardType.JackOfSpades), new Card(CardType.TenOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.KingOfSpades), new Card(CardType.QueenOfSpades), new Card(CardType.JackOfSpades), new Card(CardType.TenOfSpades), new Card(CardType.NineOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.QueenOfSpades), new Card(CardType.JackOfSpades), new Card(CardType.TenOfSpades), new Card(CardType.NineOfSpades), new Card(CardType.EightOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.JackOfSpades), new Card(CardType.TenOfSpades), new Card(CardType.NineOfSpades), new Card(CardType.EightOfSpades), new Card(CardType.SevenOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.TenOfSpades), new Card(CardType.NineOfSpades), new Card(CardType.EightOfSpades), new Card(CardType.SevenOfSpades), new Card(CardType.SixOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.NineOfSpades), new Card(CardType.EightOfSpades), new Card(CardType.SevenOfSpades), new Card(CardType.SixOfSpades), new Card(CardType.FiveOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.EightOfSpades), new Card(CardType.SevenOfSpades), new Card(CardType.SixOfSpades), new Card(CardType.FiveOfSpades), new Card(CardType.FourOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.SevenOfSpades), new Card(CardType.SixOfSpades), new Card(CardType.FiveOfSpades), new Card(CardType.FourOfSpades), new Card(CardType.ThreeOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.SixOfSpades), new Card(CardType.FiveOfSpades), new Card(CardType.FourOfSpades), new Card(CardType.ThreeOfSpades), new Card(CardType.TwoOfSpades) })},
            new object[] {new Hand(new List<ICard>() { new Card(CardType.FiveOfSpades), new Card(CardType.FourOfSpades), new Card(CardType.ThreeOfSpades), new Card(CardType.TwoOfSpades), new Card(CardType.AceOfSpades) })},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class HandRankTests
    {
        [Fact]
        public void HandRank_RankType_Should_Be_Null()
        {
            // arrange
            var handRank = new HandRank();
            var hand = new Hand(new List<ICard>());

            // act
            var rankType = handRank.GetHandRank(hand);

            // assert
            rankType.Should().BeNull();
        }

        //[Fact]
        //public void HandRank_RankType_Should_Be_Of_Type_HandRankType()
        //{
        //    // arrange
        //    var handRank = new HandRank();
        //    var hand = new Hand(new List<ICard>());

        //    // act
        //    var rankType = handRank.GetHandRank(hand);

        //    // assert
        //    rankType.Should().BeOfType(typeof(HandRankType));
        //}

        [Theory]
        #region StraightFlush ClassData
        [ClassData(typeof(StraightFlushDataGenerator))] // 5 card
        #endregion
        public void HandRank_RankType_Should_Be_Of_Type_HandRankType_StraightFlush(Hand hand)
        {
            // arrange
            var handRank = new HandRank();

            // act
            var rankType = handRank.GetHandRank(hand);

            // assert
            rankType.Should().Be(HandRankType.StraightFlush);
        }
    }
}