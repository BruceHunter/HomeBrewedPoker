// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using FluentAssertions;
using HomeBrewedPoker.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace HomeBrewedPoker.UnitTests
{
    public class PlayerTests
    {

        [Fact]
        public void Player_Id_Should_Be_Empty_When_Basic_Guid_Value_Passed_To_Constructor_Id_Parameter()
        {
            // arrange
            var player = new Player(new Guid(), null);

            // act
            var id = player.ID;

            // assert
            id.Should().BeEmpty();
        }

        [Fact]
        public void Player_Id_Should_Not_Be_Empty_When_Guid_Value_Passed_To_Constructor_Id_Parameter()
        {
            // arrange
            var player = new Player(Guid.NewGuid(), null);

            // act
            var id = player.ID;

            // assert
            id.Should().NotBeEmpty();
        }

        [Fact]
        public void Player_Hand_Should_Be_Null_When_Null_Value_Passed_To_Constructor_Hand_Parameter()
        {
            // arrange
            var player = new Player(new Guid(), null);

            // act
            var hand = player.Hand;

            // assert
            hand.Should().BeNull();
        }

        [Fact]
        public void Player_Hand_Should_Not_Be_Null_When_Hand_Value_Passed_To_Constructor_Hand_Parameter()
        {
            // arrange
            var player = new Player(new Guid(), new Hand(null));

            // act
            var hand = player.Hand;

            // assert
            hand.Should().NotBeNull();
        }

        [Fact]
        public void Player_Hand_Should_Have_Count_Equal_To_List_Of_Cards_Passed_To_Constructor_Hand_Parameter()
        {
            // arrange
            var inputCards = new List<ICard>() { new Card(CardType.FiveOfDiamonds), new Card(CardType.JackOfClubs), new Card(CardType.EightOfSpades) };
            var player = new Player(new Guid(), new Hand(inputCards));

            // act
            var cards = player.Hand.Cards;

            // assert
            cards.Should().HaveCount(inputCards.Count);
        }
    }
}