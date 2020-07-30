// Copyright (c) Bruce Hunter. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Collections;
using System.Collections.Generic;

namespace HomeBrewedPoker.UnitTests.Generators
{
    public class CardValueGenerator: IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {CardType.AceOfClubs},
            new object[] {CardType.TwoOfClubs},
            new object[] {CardType.ThreeOfClubs},
            new object[] {CardType.FourOfClubs},
            new object[] {CardType.FiveOfClubs},
            new object[] {CardType.SixOfClubs},
            new object[] {CardType.SevenOfClubs},
            new object[] {CardType.EightOfClubs},
            new object[] {CardType.NineOfClubs},
            new object[] {CardType.TenOfClubs},
            new object[] {CardType.JackOfClubs},
            new object[] {CardType.QueenOfClubs},
            new object[] {CardType.KingOfClubs},
            new object[] {CardType.AceOfDiamonds},
            new object[] {CardType.TwoOfDiamonds},
            new object[] {CardType.ThreeOfDiamonds},
            new object[] {CardType.FourOfDiamonds},
            new object[] {CardType.FiveOfDiamonds},
            new object[] {CardType.SixOfDiamonds},
            new object[] {CardType.SevenOfDiamonds},
            new object[] {CardType.EightOfDiamonds},
            new object[] {CardType.NineOfDiamonds},
            new object[] {CardType.TenOfDiamonds},
            new object[] {CardType.JackOfDiamonds},
            new object[] {CardType.QueenOfDiamonds},
            new object[] {CardType.KingOfDiamonds},
            new object[] {CardType.AceOfHearts},
            new object[] {CardType.TwoOfHearts},
            new object[] {CardType.ThreeOfHearts},
            new object[] {CardType.FourOfHearts},
            new object[] {CardType.FiveOfHearts},
            new object[] {CardType.SixOfHearts},
            new object[] {CardType.SevenOfHearts},
            new object[] {CardType.EightOfHearts},
            new object[] {CardType.NineOfHearts},
            new object[] {CardType.TenOfHearts},
            new object[] {CardType.JackOfHearts},
            new object[] {CardType.QueenOfHearts},
            new object[] {CardType.KingOfHearts},
            new object[] {CardType.AceOfSpades},
            new object[] {CardType.TwoOfSpades},
            new object[] {CardType.ThreeOfSpades},
            new object[] {CardType.FourOfSpades},
            new object[] {CardType.FiveOfSpades},
            new object[] {CardType.SixOfSpades},
            new object[] {CardType.SevenOfSpades},
            new object[] {CardType.EightOfSpades},
            new object[] {CardType.NineOfSpades},
            new object[] {CardType.TenOfSpades},
            new object[] {CardType.JackOfSpades},
            new object[] {CardType.QueenOfSpades},
            new object[] {CardType.KingOfSpades}
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
