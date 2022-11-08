using System;
namespace BasicCoreProgram

{

    public class FlipCoin
    {
        Random random = new Random();
        public void Play()
        {
            double head = 0, tail = 0;
            Console.WriteLine("No. of times you want to flip the coin");
            int num = Convert.ToInt32(Console.ReadLine());
            double ACTUAL_COUNT = num;
            while (num > 0)
            {
                if (random.NextDouble() > 0.5)
                    head++;
                else
                    tail++;
                num--;
            }
            Console.WriteLine("Head will come - " + head);
            Console.WriteLine("Tail will come - " + tail);
            double HEAD_PERCENTAGE = (head / ACTUAL_COUNT) * 100;
            double TAIL_PERCENTAGE = (tail / ACTUAL_COUNT) * 100;
            Console.WriteLine("Head Percenage will be - " + HEAD_PERCENTAGE + "\n" + "Tail Percentage will be - " + TAIL_PERCENTAGE);
        }
    }
}