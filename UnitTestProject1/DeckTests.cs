using System;
using Cards;
using NUnit.Framework;
using System.Collections.Generic;

namespace CardsTests
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void SHould_Build_New_Deck()
        {
            var deck = new DeckOfCards();

            Assert.That(deck.Count, Is.EqualTo(52));
        }
    }

    public class DeckOfCards
    {
        private List<Card> _Cards = new List<Card>();

        public DeckOfCards()
        {
            string[] suits = { "H", "S", "D", "C"};

            for(int x = 2; x < 15; x++)
            {
                for (int y = 0; y <= 3; y++)
                {
                    _Cards.Add(new Card(x,suits[y]));
                }
            }
        }

        public int Count
        {
            get { return _Cards.Count; }
        }
    }
}