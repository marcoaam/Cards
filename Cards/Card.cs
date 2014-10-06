using System.Collections;

namespace Cards
{
    public class Card
    {
        private int _value ;
        private string _suit;

        public Card(int value, string suit)
        {
            _value = value;
            _suit = suit;
        }

        public string Display
        {
            get { return string.Format("{0}{1}", GetValue(), _suit); }
        }

        private string GetValue()
        {
            var pictureCases = BuildPictureCases();

            if (_value > 10)
                return pictureCases[_value].ToString();
            return _value.ToString();
        }

        private Hashtable BuildPictureCases()
        {
            return new Hashtable {{11, "J"}, {12, "Q"}, {13, "K"}, {14, "A"}};   
        }
    }
}