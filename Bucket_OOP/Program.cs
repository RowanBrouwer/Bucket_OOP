using Bucket_OOP.Classes;
using System;

namespace Bucket_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bucket bucket1 = new Bucket {  Capacity = 12, Content = 0, IsOverFlowed = false };

            bucket1.fill(20);
            bucket1.Empty();
            bucket1.fill(6);
            bucket1.Empty(3);
        }
    }
}
