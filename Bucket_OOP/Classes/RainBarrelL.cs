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
            this.IsOverFlowed = IsOverFlowed;
        }
        public RainBarrelL(int capacity) : base(capacity)
        {
            this.Capacity = capacity;
        }

        public RainBarrelL(int content, int capacity)
        {
            this.Content = content;
            this.Capacity = capacity;
        }

        public int Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public bool IsOverFlowed
        {
            get { return _isOverflowed; }
            set { _isOverflowed = value; }
        }

        public int Spilled
        {
            get { return _spilled; }
            set { _spilled = value; }
        }

        public void FillP(int amount)
        {
            Fill(amount);
        }

        public void FillP(Container bucket)
        {
            Fill(bucket);
        }

        public void empty()
        {
            Empty();
        }

        public void empty(int amount)
        {
            Empty(amount);
        }
    }
}
