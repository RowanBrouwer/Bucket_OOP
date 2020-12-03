using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP.Classes
{
    public class EventA
    {
        private delegate void CapacityReached(Container container);
        public static void Overflowing(Container container)
        {
            CapacityReached reached = EventB.Overflowed;
            while (container._Content > container._Capacity)
            {
                container._Content--;
                container.Spilled++;
            }
            reached(container);
        }   
    }

    public class EventB
    {
        public static void Overflowed(Container container)
        {
            if (container._IsOverflowed == false)
            {
                container._IsOverflowed = true;
            }
        }
    }
}
