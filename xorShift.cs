using System;

namespace xorShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            long x = (long)((r.NextDouble() * 0.5d) * long.MaxValue);
            Random rd1 = new Random();
            long y = (long)((r.NextDouble() * 0.5d) * long.MaxValue);
            Random rd2 = new Random();
            long z = (long)((r.NextDouble() * 0.5d) * long.MaxValue);
            Random rd3 = new Random();
            long w = (long)((r.NextDouble() * 0.5d) * long.MaxValue);

            public static uint x , y , z , w ;
            public static uint xorShift()
            {
                uint t = x ^ (x << 11);
                x = y; y = z; z = w;
                return w = w ^ (w >> 19) ^ t ^ (t >> 6);
            }
        }
    }
}
