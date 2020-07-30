// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Threading.Tasks;

namespace HomeBrewedPoker.Interfaces
{
    /// <summary>
    /// Interface that defines a poker card shuffler.
    /// </summary>
    public interface ICardShuffler
    {
        /// <summary>
        /// Defines a method to determine if shuffling is in process.
        /// </summary>
        /// <returns>A <see cref="T:System.Boolean"/></returns>
        bool IsShuffling();
        /// <summary>
        /// Defines asynchronous card shuffling method.
        /// </summary>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task"/></returns>
        Task ShuffleAsync();
    }
}
