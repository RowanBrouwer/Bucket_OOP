using Bucket_OOP.Classes;
using System;

namespace Bucket_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Container bucket1 = new Bucket { Content = 0 };

            bucket1.fill(20);
            bucket1.Empty();
            bucket1.fill(6);
            bucket1.Empty(3);

            Container OilDrum1 = new OilDrum { Content = 0 };

            OilDrum1.fill(175);
            OilDrum1.Empty();
            OilDrum1.fill(6);
            OilDrum1.fill(bucket1);
            OilDrum1.Empty(3);

            Container RainbarrelS1 = new RainBarrelS { Content = 0 };

            RainbarrelS1.fill(100);
            RainbarrelS1.Empty();
            RainbarrelS1.fill(6);
            RainbarrelS1.fill(OilDrum1);
            RainbarrelS1.Empty(3);

            Container RainbarrelM1 = new RainBarrelM { Content = 0 };

            RainbarrelM1.fill(100);
            RainbarrelM1.Empty();
            RainbarrelM1.fill(6);
            RainbarrelM1.fill(OilDrum1);
            RainbarrelM1.Empty(3);

            Container RainbarrelL1 = new RainBarrelL { Content = 0 };

            RainbarrelL1.fill(100);
            RainbarrelL1.Empty();
            RainbarrelL1.fill(6);
            RainbarrelL1.fill(OilDrum1);
            RainbarrelL1.Empty(3);

        }
    }
}
