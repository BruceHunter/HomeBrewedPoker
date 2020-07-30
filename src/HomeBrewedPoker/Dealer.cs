// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using HomeBrewedPoker.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBrewedPoker
{
    /// <summary>
    /// Represents a card dealer that manages a standard 52-card deck.
    /// </summary>
    public class Dealer : IDealer
    {
        private bool _isShuffling;
        private IRandomNumberGenerator _random;

        /// <summary>
        /// Dealer constructor.
        /// </summary>
        /// <param name="random">The random number generator.</param>
        public Dealer(IRandomNumberGenerator random)
        {
            _random = random;
        }

        /// <summary>
        /// The dealers current card deck being managed.
        /// </summary>
        public IEnumerable<ICard> CardDeck { get; private set; }

        /// <summary>
        /// Determines if shuffling is in process.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsShuffling()
        {
            return _isShuffling;
        }

        /// <summary>
        /// Generate a shuffled standard 52-card poker deck.
        /// </summary>
        public virtual async Task ShuffleAsync()
        {
            _isShuffling = true;

            try
            {
                var results = await _random.GenerateIntegersAsync();

                CardDeck = results.Select(x => new Card((CardType)x));
            }
            finally
            {
                _isShuffling = false;               
            }                  
        }
    }
}
