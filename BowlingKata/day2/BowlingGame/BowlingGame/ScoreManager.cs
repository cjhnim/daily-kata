using System;


namespace BowlingGame
{
    public class ScoreManager
    {
        private const int TEN_PINS = 10;
        private const int MAX_FRAME = 10;
        private const int MAX_ROLL = 21;
        private int count;
        private int[] rolls;

        public ScoreManager()
        {
            rolls = new int[MAX_ROLL];
            count = 0;
        }

        public int score()
        {
            int score = 0;
            int rollCount = 0;

            for (int frame = 1; frame <= MAX_FRAME; frame++)
            {
                if (frame < MAX_FRAME && isStrike(rollCount))
                {
                    score += TEN_PINS;
                    score += strikeBonus(rollCount);
                    rollCount += 1;
                }
                else if (frame < MAX_FRAME && isSpare(rollCount))
                {
                    score += TEN_PINS;
                    score += spareBonus(rollCount);
                    rollCount += 2;
                }
                else
                {
                    score += rolls[rollCount];
                    score += rolls[rollCount + 1];
                    rollCount += 2;
                }
            }

            score += rolls[rollCount];
            return score;
        }

        private int spareBonus(int i)
        {
            return rolls[i + 2];
        }

        private int strikeBonus(int i)
        {
            return rolls[i + 1] + rolls[i + 2];
        }

        private bool isSpare(int i)
        {
            return rolls[i] + rolls[i + 1] == TEN_PINS;
        }

        private bool isStrike(int i)
        {
            return rolls[i] == TEN_PINS;
        }

        public void roll(int pins)
        {
            rolls[count++] = pins;
        }
    }
}