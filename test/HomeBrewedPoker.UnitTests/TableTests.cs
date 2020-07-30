// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using FluentAssertions;
using HomeBrewedPoker.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace HomeBrewedPoker.UnitTests
{
    public class TableTests
    {
        [Fact]
        public void Table_Id_Should_Be_Empty_When_Basic_Guid_Value_Passed_To_Constructor_Id_Parameter()
        {
            // arrange
            var table = new Table(new Guid(), null, null);

            // act
            var id = table.ID;

            // assert
            id.Should().BeEmpty();
        }

        [Fact]
        public void Table_Id_Should_Not_Be_Empty_When_Basic_Guid_Value_Passed_To_Constructor_Id_Parameter()
        {
            // arrange
            var table = new Table(Guid.NewGuid(), null, null);

            // act
            var id = table.ID;

            // assert
            id.Should().NotBeEmpty();
        }

        [Fact]
        public void Table_Dealer_Should_Be_Null_When_Null_Value_Passed_To_Constructor_Dealer_Parameter()
        {
            // arrange
            var table = new Table(new Guid(), null, null);

            // act
            var dealer = table.Dealer;

            // assert
            dealer.Should().BeNull();
        }

        [Fact]
        public void Table_Dealer_Should_Not_Be_Null_When_Dealer_Value_Passed_To_Constructor_Dealer_Parameter()
        {
            // arrange
            var table = new Table(new Guid(), new Dealer(null), null);

            // act
            var dealer = table.Dealer;

            // assert
            dealer.Should().NotBeNull();
        }

        [Fact]
        public void Table_Players_Should_Be_Null_When_Null_Value_Passed_To_Constructor_Players_Parameter()
        {
            // arrange
            var table = new Table(new Guid(), null, null);

            // act
            var players = table.Players;

            // assert
            players.Should().BeNull();
        }

        [Fact]
        public void Table_Players_Should_Not_Be_Null_When_List_Of_Players_Passed_To_Constructor_Players_Parameter()
        {
            // arrange
            var inputPlayers = new List<IPlayer>() { new Player(new Guid(), null) };
            var table = new Table(new Guid(), null, inputPlayers);

            // act
            var players = table.Players;

            // assert
            players.Should().NotBeNull();
        }

        [Fact]
        public void Table_Players_Should_Have_Count_Equal_To_List_Of_Players_Passed_To_Constructor_Players_Parameter()
        {
            // arrange
            var inputPlayers = new List<IPlayer>() { new Player(Guid.NewGuid(), null), new Player(Guid.NewGuid(), null) };
            var table = new Table(new Guid(), null, inputPlayers);

            // act
            var players = table.Players;

            // assert
            players.Should().HaveCount(inputPlayers.Count);
        }
    }
}