
namespace PracticaGitConsoleApp
{
    public class CardTest
    {
        public static void Test()
        {
            List<Card> cards = new List<Card>();
            Card card1 = new Card(Card.SuitType.HEARTS, 8);
            Card card2 = new Card(Card.SuitType.CLUBS, 1);
            Card card3 = new Card(Card.SuitType.DIAMONDS, 1);
            Card card4 = new Card(Card.SuitType.SPADES, 1);
            Card card5 = new Card(Card.SuitType.SPADES, 1);
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);
            PrintTest(cards);
        }

        public static void Test(int randomCardsNumber)
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < randomCardsNumber; i++)
            {
                int number = (int)Utils.GetRandom(1, 13);
                Card.SuitType suit = (Card.SuitType)Utils.GetRandom(1, 4);
                Card card = new Card(suit, number);
                cards.Add(card);
            }
            PrintTest(cards);
        }

        public static void PrintTest(List<Card> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(cards[i].GetNumber() + " " + cards[i].GetCardType());
            }
            Console.WriteLine("--");

            int score = CardUtils.Score(cards);
            string scoreComment = "";
            if (score > 21)
                scoreComment = " ¡Te pasaste!";
            Console.WriteLine("Score: " + score + scoreComment);
        }

    }
}
