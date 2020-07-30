// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using HomeBrewedPoker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HomeBrewedPoker
{
    /// <summary>
    /// A very basic ramdom number generator implementation of <see cref="HomeBrewedPoker.IRandomNumberGenerator"/>.
    /// </summary>
    public class GenericPokerCardsRandomNumberGenerator : IRandomNumberGenerator
    {
        /// <summary>
        ///  Generates random integers values of 1 through 52 with no duplicates.
        /// </summary>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task"/> that contains that random integer elements</returns>
        public Task<IEnumerable<int>> GenerateIntegersAsync()
        {
            return Task.Run(() =>
            {
                var randomIntegersList = new List<int>();
                var random = new Random();

                while (randomIntegersList.Count < 52)
                {
                    var number = random.Next(1, 53);
                    if (!randomIntegersList.Contains(number))
                    {
                        randomIntegersList.Add(number);
                    }
                }

                return randomIntegersList.AsEnumerable();
            });
        }
    }
}
