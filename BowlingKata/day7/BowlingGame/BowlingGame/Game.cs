using System;

namespace BowlingGame
{
    public class Game
    {
        int total;
        int[] scores = new int[21];
        int count;

        public Game()
        {
        }

        public void Roll(int pins)
        {
            scores[count++] = pins;
        }

        public int Score()
        {
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex))
                {
                    total += 10 + strikeBonus(frameIndex);
                    frameIndex += 1;
                }
                else if (isSpare(frameIndex))
                {
                    total += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    total += ballOfSumInFrame(frameIndex);
                    frameIndex += 2;
                }
            }

            return total;
        }

        private int ballOfSumInFrame(int frameIndex)
        {
            return scores[frameIndex] + scores[frameIndex + 1];
        }

        private int spareBonus(int frameIndex)
        {
            return scores[frameIndex + 2];
        }

        private int strikeBonus(int frameIndex)
        {
            return scores[frameIndex + 1] + scores[frameIndex + 2];
        }

        private bool isSpare(int frameIndex)
        {
            return scores[frameIndex] + scores[frameIndex + 1] == 10;
        }

        private bool isStrike(int frameIndex)
        {
            return scores[frameIndex] == 10;
        }
    }
}