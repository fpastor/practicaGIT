
namespace PracticaGitConsoleApp
{
    public class CardUtils
    {
        public static int Score(List<Card> cards)
        {
            Sort(cards);
            int score = 0;
            int aceCount = 0;
            int Count = cards.Count;
            for (int i = 0; i < Count; i++)
            {
                bool figure = cards[i].IsFigure();
                if (figure)
                    score += 10;
                else
                {
                    int number = cards[i].GetNumber();
                    if (number == 1)
                    {
                        score += 11;
                        aceCount++;
                        while (score > 21 && aceCount > 0)
                        {
                            score -= 10;
                            aceCount--;
                        }
                    }
                    else
                        score += number;
                }
            }
            return score;
        }

        public static void Sort(List<Card> cards)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                for (int j = i + 1; j < cards.Count; j++)
                {
                    if (cards[i].GetNumber() < cards[j].GetNumber())
                        Swap(cards, i, j);
                }
            }
        }

        public static void Swap(List<Card> cards, int i, int j)
        {
            Card aux = cards[i];
            cards[i] = cards[j];
            cards[j] = aux;
        }

    }
}
