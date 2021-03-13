// Copyright (c) Bruce Hunter Jr. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace HomeBrewedPoker
{
    /// <summary>
    /// Represents Poker Player Actions.
    /// </summary>
    public enum PlayerActionType
    {
        /// <summary>
        /// Represents a fold action.
        /// </summary>
        Fold = 1,
        /// <summary>
        /// Represents a check action.
        /// </summary>
        Check,
        /// <summary>
        /// Represents a call action.
        /// </summary>
        Call,
        /// <summary>
        /// Represents a bet action.
        /// </summary>
        Bet,
        /// <summary>
        /// Represents a raise action.
        /// </summary>
        Raise
    }
}
