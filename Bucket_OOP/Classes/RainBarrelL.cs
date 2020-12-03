using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP.Classes
{
    public sealed class RainBarrelL : Container
    {
        public RainBarrelL() : base()
        {
            Capacity = 159;
            this._IsOverflowed = _IsOverflowed;
        }
        public RainBarrelL(int capacity) : base(capacity)
        {
            this._Capacity = capacity;
        }

        public RainBarrelL(int content, int capacity)
        {
            this._Content = content;
            this._Capacity = capacity;
        }
        public int Content
        {
            get { return _Content; }
            set { _Content = value; }
        }
        public int Capacity
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }

        public bool IsOverFlowed
        {
            get { return _IsOverflowed; }
            set { _IsOverflowed = value; }
        }
    }
}
