using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP.Classes
{
    public sealed class Bucket : Container
    {
        #region
        private delegate void CapacityReached(Bucket bucket);
        #endregion

        public Bucket() : base()
        {
            this._IsOverflowed = _IsOverflowed;
        }
        public Bucket(int capacity) : base(capacity)
        {
            this._Capacity = capacity;
        }

        public Bucket(int content, int capacity)
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
