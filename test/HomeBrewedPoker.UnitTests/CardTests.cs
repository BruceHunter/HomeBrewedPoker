// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Xunit;
using FluentAssertions;

namespace HomeBrewedPoker.UnitTests
{
    public class CardTests
    {
        [Theory]
        #region RankType InlineData
        [InlineData(CardType.AceOfClubs, RankType.Ace)]
        [InlineData(CardType.AceOfDiamonds, RankType.Ace)]
        [InlineData(CardType.AceOfHearts, RankType.Ace)]
        [InlineData(CardType.AceOfSpades, RankType.Ace)]
        [InlineData(CardType.TwoOfClubs, RankType.Two)]
        [InlineData(CardType.TwoOfDiamonds, RankType.Two)]
        [InlineData(CardType.TwoOfHearts, RankType.Two)]
        [InlineData(CardType.TwoOfSpades, RankType.Two)]
        [InlineData(CardType.ThreeOfClubs, RankType.Three)]
        [InlineData(CardType.ThreeOfDiamonds, RankType.Three)]
        [InlineData(CardType.ThreeOfHearts, RankType.Three)]
        [InlineData(CardType.ThreeOfSpades, RankType.Three)]
        [InlineData(CardType.FourOfClubs, RankType.Four)]
        [InlineData(CardType.FourOfDiamonds, RankType.Four)]
        [InlineData(CardType.FourOfHearts, RankType.Four)]
        [InlineData(CardType.FourOfSpades, RankType.Four)]
        [InlineData(CardType.FiveOfClubs, RankType.Five)]
        [InlineData(CardType.FiveOfDiamonds, RankType.Five)]
        [InlineData(CardType.FiveOfHearts, RankType.Five)]
        [InlineData(CardType.FiveOfSpades, RankType.Five)]
        [InlineData(CardType.SixOfClubs, RankType.Six)]
        [InlineData(CardType.SixOfDiamonds, RankType.Six)]
        [InlineData(CardType.SixOfHearts, RankType.Six)]
        [InlineData(CardType.SixOfSpades, RankType.Six)]
        [InlineData(CardType.SevenOfClubs, RankType.Seven)]
        [InlineData(CardType.SevenOfDiamonds, RankType.Seven)]
        [InlineData(CardType.SevenOfHearts, RankType.Seven)]
        [InlineData(CardType.SevenOfSpades, RankType.Seven)]
        [InlineData(CardType.EightOfClubs, RankType.Eight)]
        [InlineData(CardType.EightOfDiamonds, RankType.Eight)]
        [InlineData(CardType.EightOfHearts, RankType.Eight)]
        [InlineData(CardType.EightOfSpades, RankType.Eight)]
        [InlineData(CardType.NineOfClubs, RankType.Nine)]
        [InlineData(CardType.NineOfDiamonds, RankType.Nine)]
        [InlineData(CardType.NineOfHearts, RankType.Nine)]
        [InlineData(CardType.NineOfSpades, RankType.Nine)]
        [InlineData(CardType.TenOfClubs, RankType.Ten)]
        [InlineData(CardType.TenOfDiamonds, RankType.Ten)]
        [InlineData(CardType.TenOfHearts, RankType.Ten)]
        [InlineData(CardType.TenOfSpades, RankType.Ten)]
        [InlineData(CardType.JackOfClubs, RankType.Jack)]
        [InlineData(CardType.JackOfDiamonds, RankType.Jack)]
        [InlineData(CardType.JackOfHearts, RankType.Jack)]
        [InlineData(CardType.JackOfSpades, RankType.Jack)]
        [InlineData(CardType.QueenOfClubs, RankType.Queen)]
        [InlineData(CardType.QueenOfDiamonds, RankType.Queen)]
        [InlineData(CardType.QueenOfHearts, RankType.Queen)]
        [InlineData(CardType.QueenOfSpades, RankType.Queen)]
        [InlineData(CardType.KingOfClubs, RankType.King)]
        [InlineData(CardType.KingOfDiamonds, RankType.King)]
        [InlineData(CardType.KingOfHearts, RankType.King)]
        [InlineData(CardType.KingOfSpades, RankType.King)]
        #endregion
        public void Card_GetRank_Should_Be_Valid_RankType_For_CardType(CardType cardType, RankType rankType)
        {
            // arrange
            var card = new Card(cardType);

            // act
            var result = card.GetRank();

            // assert
            result.Should().Be(rankType);
        }

        [Theory]
        #region SuitType InlineData
        [InlineData(CardType.AceOfClubs, SuitType.Clubs)]
        [InlineData(CardType.AceOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.AceOfHearts, SuitType.Hearts)]
        [InlineData(CardType.AceOfSpades, SuitType.Spades)]
        [InlineData(CardType.TwoOfClubs, SuitType.Clubs)]
        [InlineData(CardType.TwoOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.TwoOfHearts, SuitType.Hearts)]
        [InlineData(CardType.TwoOfSpades, SuitType.Spades)]
        [InlineData(CardType.ThreeOfClubs, SuitType.Clubs)]
        [InlineData(CardType.ThreeOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.ThreeOfHearts, SuitType.Hearts)]
        [InlineData(CardType.ThreeOfSpades, SuitType.Spades)]
        [InlineData(CardType.FourOfClubs, SuitType.Clubs)]
        [InlineData(CardType.FourOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.FourOfHearts, SuitType.Hearts)]
        [InlineData(CardType.FourOfSpades, SuitType.Spades)]
        [InlineData(CardType.FiveOfClubs, SuitType.Clubs)]
        [InlineData(CardType.FiveOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.FiveOfHearts, SuitType.Hearts)]
        [InlineData(CardType.FiveOfSpades, SuitType.Spades)]
        [InlineData(CardType.SixOfClubs, SuitType.Clubs)]
        [InlineData(CardType.SixOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.SixOfHearts, SuitType.Hearts)]
        [InlineData(CardType.SixOfSpades, SuitType.Spades)]
        [InlineData(CardType.SevenOfClubs, SuitType.Clubs)]
        [InlineData(CardType.SevenOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.SevenOfHearts, SuitType.Hearts)]
        [InlineData(CardType.SevenOfSpades, SuitType.Spades)]
        [InlineData(CardType.EightOfClubs, SuitType.Clubs)]
        [InlineData(CardType.EightOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.EightOfHearts, SuitType.Hearts)]
        [InlineData(CardType.EightOfSpades, SuitType.Spades)]
        [InlineData(CardType.NineOfClubs, SuitType.Clubs)]
        [InlineData(CardType.NineOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.NineOfHearts, SuitType.Hearts)]
        [InlineData(CardType.NineOfSpades, SuitType.Spades)]
        [InlineData(CardType.TenOfClubs, SuitType.Clubs)]
        [InlineData(CardType.TenOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.TenOfHearts, SuitType.Hearts)]
        [InlineData(CardType.TenOfSpades, SuitType.Spades)]
        [InlineData(CardType.JackOfClubs, SuitType.Clubs)]
        [InlineData(CardType.JackOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.JackOfHearts, SuitType.Hearts)]
        [InlineData(CardType.JackOfSpades, SuitType.Spades)]
        [InlineData(CardType.QueenOfClubs, SuitType.Clubs)]
        [InlineData(CardType.QueenOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.QueenOfHearts, SuitType.Hearts)]
        [InlineData(CardType.QueenOfSpades, SuitType.Spades)]
        [InlineData(CardType.KingOfClubs, SuitType.Clubs)]
        [InlineData(CardType.KingOfDiamonds, SuitType.Diamonds)]
        [InlineData(CardType.KingOfHearts, SuitType.Hearts)]
        [InlineData(CardType.KingOfSpades, SuitType.Spades)]
        #endregion
        public void Card_GetRank_Should_Be_Valid_SuitType_For_CardType(CardType cardType, SuitType suitType)
        {
            // arrange
            var card = new Card(cardType);

            // act
            var result = card.GetSuit();

            // assert
            result.Should().Be(suitType);
        }
    }
}
