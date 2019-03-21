using System;

namespace BowlingGame
{
    public class Game
    {
        int total = 0;
        int[] rolls = new int[21];
        int currentRoll = 0;

        public Game()
        {
        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[frameIndex] == 10)
                {
                    total += 10 + StrikeBonus(frameIndex);
                    frameIndex += 1;
                }
                else if (IsSpare(frameIndex))
                {
                    total += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    total += BallOfSumInFrame(frameIndex);
                    frameIndex += 2;
                }
            }

            return total;
        }

        private int BallOfSumInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        private int SpareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private int StrikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private bool IsSpare(int i)
        {
            return rolls[i] + rolls[i + 1] == 10;
        }
    }
}