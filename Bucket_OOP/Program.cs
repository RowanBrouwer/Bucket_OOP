using Bucket_OOP.Classes;
using System;

namespace Bucket_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bucket bucket1 = new Bucket {  Content = 0};
            bucket1.Fill(20);
            bucket1.empty();
            bucket1.Fill(6);
            bucket1.empty(3);

            OilDrum OilDrum1 = new OilDrum { Content = 0 };

            OilDrum1.Fill(175);
            OilDrum1.empty();
            OilDrum1.Fill(6);
            OilDrum1.Fill(bucket1);
            OilDrum1.empty(3);

            RainBarrelS RainbarrelS1 = new RainBarrelS { Content = 0 };

            RainbarrelS1.Fill(100);
            RainbarrelS1.empty();
            RainbarrelS1.Fill(6);
            RainbarrelS1.Fill(OilDrum1);
            RainbarrelS1.empty(3);

            RainBarrelM RainbarrelM1 = new RainBarrelM { Content = 0 };

            RainbarrelM1.Fill(100);
            RainbarrelM1.empty();
            RainbarrelM1.Fill(6);
            RainbarrelM1.Fill(OilDrum1);
            RainbarrelM1.empty(3);

            RainBarrelL RainbarrelL1 = new RainBarrelL { Content = 0 };

            RainbarrelL1.Fill(100);
            RainbarrelL1.empty();
            RainbarrelL1.Fill(6);
            RainbarrelL1.Fill(OilDrum1);
            RainbarrelL1.empty(3);

        }
    }
}
