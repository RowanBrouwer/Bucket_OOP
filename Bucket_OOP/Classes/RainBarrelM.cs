using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP.Classes
{
    public sealed class RainBarrelM : Container
    {
        public RainBarrelM() : base()
        {
            Capacity = 120;
            this.IsOverFlowed = IsOverFlowed;
        }
        public RainBarrelM(int capacity) : base(capacity)
        {
            this.Capacity = capacity;
        }

        public RainBarrelM(int content, int capacity)
        {
            this.Content = content;
            this.Content = capacity;
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
