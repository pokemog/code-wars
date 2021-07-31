using System;

namespace BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BouncingBall bouncingBall = new BouncingBall();
            int seenCount = BouncingBall.bouncingBall(3, .66, 1.5);
            Console.WriteLine($"Number of times seen is: {seenCount}");
        }
    }
}
