// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using FluentAssertions;
using HomeBrewedPoker.Interfaces;
using System.Collections.Generic;
using Xunit;

namespace HomeBrewedPoker.UnitTests
{
    public class HandTests
    {
        [Fact]
        public void Hand_Cards_Should_Be_Null_When_Null_Value_Passed_To_Constructor_Cards_Parameter()
        {
            // arrange
            var hand = new Hand(null);

            // act
            var cards = hand.Cards;

            // assert
            cards.Should().BeNull();
        }

        [Fact]
        public void Hand_Cards_Should_Not_Be_Null_When_List_Of_Cards_Passed_To_Constructor_Cards_Parameter()
        {
            // arrange
            var inputCards = new List<ICard>() { new Card(CardType.AceOfClubs) };
            var hand = new Hand(inputCards);

            // act
            var cards = hand.Cards;

            // assert
            cards.Should().NotBeNull();
        }

        [Fact]
        public void Hand_Cards_Should_Have_Count_Equal_To_List_Of_Cards_Passed_To_Constructor_Cards_Parameter()
        {
            // arrange
            var inputCards = new List<ICard>() { new Card(CardType.AceOfClubs), new Card(CardType.EightOfClubs) };
            var hand = new Hand(inputCards);

            // act
            var cards = hand.Cards;

            // assert
            cards.Should().HaveCount(inputCards.Count);
        }
    }
}