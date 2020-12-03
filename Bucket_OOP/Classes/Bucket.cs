using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP.Classes
{
    sealed class Bucket : BucketBase
    {
        #region
        private int _content { get; set; }
        private int _capacity { get; set; }
        #endregion


        public Bucket(int content, int capacity) : base(content, capacity)
        {
            if (capacity >= content && capacity > 10 || capacity < 12)
            {
                this._content = content; this._capacity = capacity;
            }
            else
            {
                this.Capacity = 12; this.Content = 0;
            }
        }
        protected override void fill(int amount)
        {
            
        }
    }
}
