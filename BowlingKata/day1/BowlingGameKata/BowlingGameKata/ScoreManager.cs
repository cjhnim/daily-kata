using System;

namespace BowlingGameKata
{
    public class ScoreManager
    {
        int total;
        int count;
        int frame;

        public ScoreManager()
        {
        }

        public void roll(int pins)
        {
            if (spareCheck())
            {
                if (isSpare())
                    total += pins;

                clearFrame();
            }

            if (strikeCheck())
            {
                if (frame == 10)
                {
                    total += pins;
                    clearFrame();
                }
            }

            total += pins;
            frame += pins;
            count++;
        }

        private bool strikeCheck()
        {
            return (count % 2) == 1;
        }

        private void clearFrame()
        {
            frame = 0;
            count = 0;
        }

        private bool spareCheck()
        {
            return (count % 2) == 0;
        }

        private bool isSpare()
        {
            return frame == 10;
        }

        public int score()
        {
            return total;
        }
    }
}