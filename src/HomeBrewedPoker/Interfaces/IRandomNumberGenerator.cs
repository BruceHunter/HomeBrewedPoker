// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeBrewedPoker.Interfaces
{
    /// <summary>
    /// Interface that defines a random number generator.
    /// </summary>
    public interface IRandomNumberGenerator
    {
        /// <summary>
        /// Defines a method to generate random integers values.
        /// </summary>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task"/> that contains that random integer elements.</returns>
        Task<IEnumerable<int>> GenerateIntegersAsync();
    }
}