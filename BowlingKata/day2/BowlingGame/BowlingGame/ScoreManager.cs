using System;

namespace BowlingGame
{
    public class ScoreManager
    {
        private int count;
        private int[] scores;

        public ScoreManager()
        {
            scores = new int[20];
            count = 0;
        }

        public int score()
        {
            int total = 0;

            for (int i = 0; i < 20; i+=2)
            {
                total += scores[i];
                total += scores[i + 1];

                if (i >1 && scores[i-2] == 10)
                {
                    total += scores[i];
                    total += scores[i+1];
                }
                else if (i > 1 && scores[i-2] + scores[i-1] == 10)
                {
                    total += scores[i];
                }
            }

            return total;
        }

        public void roll(int pins)
        {
            scores[count++] = pins;

            if (pins == 10)
                count++;
        }
    }
}