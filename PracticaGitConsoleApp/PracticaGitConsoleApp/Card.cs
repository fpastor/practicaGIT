
namespace PracticaGitConsoleApp
{
    public class Card
    {
        public enum SuitType
        {
            HEARTS, DIAMONDS, SPADES, CLUBS, JOKER
        }

        public enum ColorType
        {
            RED, BLACK, JOKER
        }

        public enum FigureType
        {
            ACE, KING, QUEEN, JACK, NONE
        }

        private SuitType _suit;
        private int _number;

        public Card(SuitType suit, int number)
        {
            _suit = suit;
            _number = number;
        }

        public bool IsValid()
        {
            return 0 <= _number && _number <= 13;
        }

        public SuitType GetCardType()
        {
            return _suit;
        }

        public int GetNumber()
        {
            return _number;
        }

        public ColorType GetColor()
        {
            if ((GetCardType() == SuitType.HEARTS) || (GetCardType() == SuitType.DIAMONDS))
                return ColorType.RED;
            else if ((GetCardType() == SuitType.SPADES) || (GetCardType() == SuitType.CLUBS))
                return ColorType.BLACK;
            else
                return ColorType.JOKER;
        }

        public bool IsFigure()
        {
            if (IsValid())
                return false;
            return 11 <= _number && _number <= 13;
        }

        public FigureType GetFigureType()
        {
            if (_number == 11)
                return FigureType.JACK;
            if (_number == 12)
                return FigureType.QUEEN;
            if (_number == 13)
                return FigureType.KING;
            return FigureType.NONE;
        }

    }
}
