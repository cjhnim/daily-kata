using System;

namespace BowlingGame
{
    public class ScoreBoard
    {
        private const int MAX_COUNT = 21;
        private const int MAX_FRAME = 10;
        private const int TEN = 10;
        int total;
        int count;
        int[] scores;

        public ScoreBoard()
        {
            total = 0;
            count = 0;
            scores = new int[MAX_COUNT];
        }

        public void roll(int pins)
        {
            scores[count++] = pins;
        }

        public int score()
        {
            int i = 0;

            for (int frame = 1; frame <= MAX_FRAME; frame++)
            {
                if (frame < MAX_FRAME && isStrike(i))
                {
                    total += TEN;
                    total += strikeBonus(i);
                    i += 1;
                }
                else
                {
                    if (frame < MAX_FRAME && isSpare(i))
                        total += spareBonus(i);

                    total += scores[i];
                    total += scores[i + 1];
                    i += 2;
                }
            }

            total += scores[i];

            return total;
        }

        private int spareBonus(int i)
        {
            return scores[i + 2];
        }

        private int strikeBonus(int i)
        {
            return scores[i + 1] + scores[i + 2];
        }

        private bool isSpare(int i)
        {
            return (scores[i] + scores[i + 1]) == TEN;
        }

        private bool isStrike(int i)
        {
            return scores[i] == TEN;
        }
    }
}