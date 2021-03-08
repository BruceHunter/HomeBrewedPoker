// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using FluentAssertions;
using HomeBrewedPoker.Interfaces;
using System;
using Xunit;

namespace HomeBrewedPoker.UnitTests
{
    public class DealerTests : IDisposable
    {
        IRandomNumberGenerator generator;

        public DealerTests()
        {
            // arrange
            generator = new GenericPokerCardsRandomNumberGenerator();
        }

        [Fact]
        public void Dealer_CardDeck_Should_Be_Null()
        {
            // act
            var dealer = new Dealer(generator);

            // assert
            dealer.CardDeck.Should().BeNull();
        }

        [Fact]
        public void Dealer_IsShuffling_Should_Be_False()
        {
            // act
            var dealer = new Dealer(generator);

            // assert
            dealer.IsShuffling().Should().BeFalse();
        }

        [Fact]
        public async void Dealer_ShuffleAsync_Card_Deck_Should_Not_Be_Null()
        {
            // arrange
            var dealer = new Dealer(generator);

            // act
            await dealer.ShuffleAsync();

            // assert
            dealer.CardDeck.Should().NotBeNull();
        }

        [Fact (Skip = "Execution is fast and isShuffling returns False. Timing Issue with this Fact.")]
        
        public void Dealer_IsShuffling_Should_Be_True_When_Shuffle_Async_Execution_Inprogress()
        {
            // arrange
            var dealer = new Dealer(generator);

            // act
            _ = dealer.ShuffleAsync();
            var isShuffling = dealer.IsShuffling();

            // assert
            isShuffling.Should().BeTrue();
        }

        [Fact]
        public async void Dealer_IsShuffling_Should_Be_False_When_Shuffle_Async_Execution_Completed()
        {
            // arrange
            var dealer = new Dealer(generator);

            // act
            await dealer.ShuffleAsync();
            var isShuffling = dealer.IsShuffling();

            // assert
            isShuffling.Should().BeFalse();
        }

        public void Dispose()
        {
            generator = null;
        }
    }
}