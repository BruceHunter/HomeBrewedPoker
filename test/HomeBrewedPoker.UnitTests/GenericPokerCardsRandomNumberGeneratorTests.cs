// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using FluentAssertions;
using HomeBrewedPoker.Interfaces;
using HomeBrewedPoker.UnitTests.Generators;
using System;
using Xunit;

namespace HomeBrewedPoker.UnitTests
{
    public class GenericPokerCardsRandomNumberGeneratorTests: IDisposable
    {
        IRandomNumberGenerator generator;

        public GenericPokerCardsRandomNumberGeneratorTests()
        {
            // arrange
            generator = new GenericPokerCardsRandomNumberGenerator();
        }

        [Theory]
        [ClassData(typeof(CardValueGenerator))]
        public async void GenericPokerCardsRandomNumberGenerator_GenerateIntegersAsync_Should_Contain_1_Through_52(int input)
        {
            // act
            var numbers = await generator.GenerateIntegersAsync();

            // assert
            numbers.Should().Contain(input);
        }

        [Fact]
        public async void GenericPokerCardsRandomNumberGenerator_GenerateIntegersAsync_Should_Have_Count_52()
        {
            // act
            var numbers = await generator.GenerateIntegersAsync();

            // assert
            numbers.Should().HaveCount(52);
        }

        [Fact]
        public async void GenericPokerCardsRandomNumberGenerator_GenerateIntegersAsync_Should_Only_Contain_Less_Than_53()
        {
            // act
            var numbers = await generator.GenerateIntegersAsync();

            // assert
            numbers.Should().OnlyContain(x => x < 53);
        }

        [Fact]
        public async void GenericPokerCardsRandomNumberGenerator_GenerateIntegersAsync_Should_Only_Contain_Greater_Than_0()
        {
            // act
            var numbers = await generator.GenerateIntegersAsync();

            // assert
            numbers.Should().OnlyContain(x => x > 0);
        }

        public void Dispose()
        {
            generator = null;
        }
    }
}