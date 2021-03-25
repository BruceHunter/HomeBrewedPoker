using HomeBrewedPoker.Interfaces;
using HomeBrewedPoker.Types;
using System.Collections;
using System.Collections.Generic;

namespace HomeBrewedPoker
{
    /// <summary>
    /// 
    /// </summary>
    public class StraightFlushDataGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly IList<IList<IHand>> HandData = new List<IList<IHand>>
        {
            //Clubs
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.AceOfClubs), new Card(CardType.KingOfClubs), new Card(CardType.QueenOfClubs), new Card(CardType.JackOfClubs), new Card(CardType.TenOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.KingOfClubs), new Card(CardType.QueenOfClubs), new Card(CardType.JackOfClubs), new Card(CardType.TenOfClubs), new Card(CardType.NineOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.QueenOfClubs), new Card(CardType.JackOfClubs), new Card(CardType.TenOfClubs), new Card(CardType.NineOfClubs), new Card(CardType.EightOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.JackOfClubs), new Card(CardType.TenOfClubs), new Card(CardType.NineOfClubs), new Card(CardType.EightOfClubs), new Card(CardType.SevenOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.TenOfClubs), new Card(CardType.NineOfClubs), new Card(CardType.EightOfClubs), new Card(CardType.SevenOfClubs), new Card(CardType.SixOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.NineOfClubs), new Card(CardType.EightOfClubs), new Card(CardType.SevenOfClubs), new Card(CardType.SixOfClubs), new Card(CardType.FiveOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.EightOfClubs), new Card(CardType.SevenOfClubs), new Card(CardType.SixOfClubs), new Card(CardType.FiveOfClubs), new Card(CardType.FourOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.SevenOfClubs), new Card(CardType.SixOfClubs), new Card(CardType.FiveOfClubs), new Card(CardType.FourOfClubs), new Card(CardType.ThreeOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.SixOfClubs), new Card(CardType.FiveOfClubs), new Card(CardType.FourOfClubs), new Card(CardType.ThreeOfClubs), new Card(CardType.TwoOfClubs) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.FiveOfClubs), new Card(CardType.FourOfClubs), new Card(CardType.ThreeOfClubs), new Card(CardType.TwoOfClubs), new Card(CardType.AceOfClubs) })},
                     
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.AceOfDiamonds), new Card(CardType.KingOfDiamonds), new Card(CardType.QueenOfDiamonds), new Card(CardType.JackOfDiamonds), new Card(CardType.TenOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.KingOfDiamonds), new Card(CardType.QueenOfDiamonds), new Card(CardType.JackOfDiamonds), new Card(CardType.TenOfDiamonds), new Card(CardType.NineOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.QueenOfDiamonds), new Card(CardType.JackOfDiamonds), new Card(CardType.TenOfDiamonds), new Card(CardType.NineOfDiamonds), new Card(CardType.EightOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.JackOfDiamonds), new Card(CardType.TenOfDiamonds), new Card(CardType.NineOfDiamonds), new Card(CardType.EightOfDiamonds), new Card(CardType.SevenOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.TenOfDiamonds), new Card(CardType.NineOfDiamonds), new Card(CardType.EightOfDiamonds), new Card(CardType.SevenOfDiamonds), new Card(CardType.SixOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.NineOfDiamonds), new Card(CardType.EightOfDiamonds), new Card(CardType.SevenOfDiamonds), new Card(CardType.SixOfDiamonds), new Card(CardType.FiveOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.EightOfDiamonds), new Card(CardType.SevenOfDiamonds), new Card(CardType.SixOfDiamonds), new Card(CardType.FiveOfDiamonds), new Card(CardType.FourOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.SevenOfDiamonds), new Card(CardType.SixOfDiamonds), new Card(CardType.FiveOfDiamonds), new Card(CardType.FourOfDiamonds), new Card(CardType.ThreeOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.SixOfDiamonds), new Card(CardType.FiveOfDiamonds), new Card(CardType.FourOfDiamonds), new Card(CardType.ThreeOfDiamonds), new Card(CardType.TwoOfDiamonds) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.FiveOfDiamonds), new Card(CardType.FourOfDiamonds), new Card(CardType.ThreeOfDiamonds), new Card(CardType.TwoOfDiamonds), new Card(CardType.AceOfDiamonds) })},
                     
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.AceOfHearts), new Card(CardType.KingOfHearts), new Card(CardType.QueenOfHearts), new Card(CardType.JackOfHearts), new Card(CardType.TenOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.KingOfHearts), new Card(CardType.QueenOfHearts), new Card(CardType.JackOfHearts), new Card(CardType.TenOfHearts), new Card(CardType.NineOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.QueenOfHearts), new Card(CardType.JackOfHearts), new Card(CardType.TenOfHearts), new Card(CardType.NineOfHearts), new Card(CardType.EightOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.JackOfHearts), new Card(CardType.TenOfHearts), new Card(CardType.NineOfHearts), new Card(CardType.EightOfHearts), new Card(CardType.SevenOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.TenOfHearts), new Card(CardType.NineOfHearts), new Card(CardType.EightOfHearts), new Card(CardType.SevenOfHearts), new Card(CardType.SixOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.NineOfHearts), new Card(CardType.EightOfHearts), new Card(CardType.SevenOfHearts), new Card(CardType.SixOfHearts), new Card(CardType.FiveOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.EightOfHearts), new Card(CardType.SevenOfHearts), new Card(CardType.SixOfHearts), new Card(CardType.FiveOfHearts), new Card(CardType.FourOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.SevenOfHearts), new Card(CardType.SixOfHearts), new Card(CardType.FiveOfHearts), new Card(CardType.FourOfHearts), new Card(CardType.ThreeOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.SixOfHearts), new Card(CardType.FiveOfHearts), new Card(CardType.FourOfHearts), new Card(CardType.ThreeOfHearts), new Card(CardType.TwoOfHearts) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.FiveOfHearts), new Card(CardType.FourOfHearts), new Card(CardType.ThreeOfHearts), new Card(CardType.TwoOfHearts), new Card(CardType.AceOfHearts) })},
                     
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.AceOfSpades), new Card(CardType.KingOfSpades), new Card(CardType.QueenOfSpades), new Card(CardType.JackOfSpades), new Card(CardType.TenOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.KingOfSpades), new Card(CardType.QueenOfSpades), new Card(CardType.JackOfSpades), new Card(CardType.TenOfSpades), new Card(CardType.NineOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.QueenOfSpades), new Card(CardType.JackOfSpades), new Card(CardType.TenOfSpades), new Card(CardType.NineOfSpades), new Card(CardType.EightOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.JackOfSpades), new Card(CardType.TenOfSpades), new Card(CardType.NineOfSpades), new Card(CardType.EightOfSpades), new Card(CardType.SevenOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.TenOfSpades), new Card(CardType.NineOfSpades), new Card(CardType.EightOfSpades), new Card(CardType.SevenOfSpades), new Card(CardType.SixOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.NineOfSpades), new Card(CardType.EightOfSpades), new Card(CardType.SevenOfSpades), new Card(CardType.SixOfSpades), new Card(CardType.FiveOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.EightOfSpades), new Card(CardType.SevenOfSpades), new Card(CardType.SixOfSpades), new Card(CardType.FiveOfSpades), new Card(CardType.FourOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.SevenOfSpades), new Card(CardType.SixOfSpades), new Card(CardType.FiveOfSpades), new Card(CardType.FourOfSpades), new Card(CardType.ThreeOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.SixOfSpades), new Card(CardType.FiveOfSpades), new Card(CardType.FourOfSpades), new Card(CardType.ThreeOfSpades), new Card(CardType.TwoOfSpades) })},
            new List<IHand>() {new Hand(new List<ICard>() { new Card(CardType.FiveOfSpades), new Card(CardType.FourOfSpades), new Card(CardType.ThreeOfSpades), new Card(CardType.TwoOfSpades), new Card(CardType.AceOfSpades) })},
        };
    }

    /// <summary>
    /// 
    /// </summary>
    public class HandRank : IHandRank
    {


        /// <summary>
        /// Represents a hand rank for 5 and 7 card poker.
        /// </summary>
        public HandRank()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        public HandRankType? GetHandRank(IHand hand)
        {
            if(HasStraightFlush(hand))
            {
                return HandRankType.StraightFlush;
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        public bool HasStraightFlush(IHand hand)
        {
            if (HasValidHand(hand))
            {
                IList<ICard> matchingSampleCards = new List<ICard>();

                foreach(var itemHand in StraightFlushDataGenerator.HandData)
                {
                    matchingSampleCards.Clear();
                    foreach (var card in (itemHand[0].Cards))
                    {
                        foreach (var handCard in hand.Cards) {
                            if (card.GetRank() == handCard.GetRank() && card.GetSuit() == handCard.GetSuit())
                            {
                                matchingSampleCards.Add(card);

                                if (matchingSampleCards.Count == 5)
                                {
                                    return true;
                                }
                            }
                        }                        
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        public bool HasStraight(IHand hand)
        {
            if (HasValidHand(hand))
            {
                return false;
            }
                //var cardList = new List<ICard>();
                //foreach (var card in hand.Cards.)
                //{
                //    cardList.Add(card);
                //}

                //if (cardList.Any() && cardList) ;

                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        public bool HasFlush(IHand hand)
        {
            if(HasValidHand(hand))
            {
                SuitType? suitTypeSample = null;
                foreach(var card in hand.Cards)
                {
                    if(suitTypeSample == null)
                    {
                        suitTypeSample = card.GetSuit();
                    }
                    else
                    {
                        if(suitTypeSample != card.GetSuit())
                        {
                            return false;
                        }
                    }                    
                }
                return true;
            }
            return false;
        }

        private bool HasValidHand(IHand hand)
        {
            if (hand != null && hand.Cards != null && (hand.Cards.Count == 5 || hand.Cards.Count == 7))
            {
                return true;
            }

            return false;
        }
    }
}
