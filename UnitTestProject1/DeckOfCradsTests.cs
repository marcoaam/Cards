
using System;
using System.Linq;
using Cards;
using NUnit.Framework;

namespace CardsTests
{
    [TestFixture]
    public class CardTests
    {
        [TestCase(2, "H", "2H")]
        [TestCase(10, "H", "10H")]
        public void DisplaysTheValue(int value, string suit, string expectedDisplayValue)
        {
            var card = new Card(value, suit);

            Assert.That(card.Display, Is.EqualTo(expectedDisplayValue));
        }

        [TestCase(11,"H", "JH")]
        [TestCase(12, "H", "QH")]
        [TestCase(13, "H", "KH")]
        [TestCase(14, "H", "AH")]
        public void Displays_The_Value_As_J_if_value_11(int value, string suit, string expectedDisplayValue)
        {
            Card card = new Card(value, suit);

            Assert.That(card.Display, Is.EqualTo(expectedDisplayValue));
        }
    }
}
