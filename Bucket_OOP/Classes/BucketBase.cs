using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bucket_OOP.Classes
{
    abstract class BucketBase
    {
        #region
        private int _Capacity { get; set; }
        private int _Content { get; set; }
        #endregion

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


        protected BucketBase()
        {
        }

        protected BucketBase(int content)
        {
            this._Content = content;
        }
        
        protected BucketBase(int content, int capacity)
        {
            this._Capacity = capacity; this._Content = content;
        }
        

        protected virtual void fill(int amount)
        {
            if (_Content + amount <= _Capacity && _Content + amount >= 0)
            {
                _Content += amount;
            }
            else
            {
                _Content += amount;
                Overflowing(this);
            }
        }

        protected virtual void fill(BucketBase bucket)
        {
            int Amount = bucket._Content;
            fill(Amount);
        }

        protected virtual void Empty()
        {
            _Content = 0;
        }

        protected virtual void Empty(int amount)
        {
            _Content -= amount;
            if (Content <= 0)
            {
                Content = 0;
            }
        }

        protected virtual void Full()
        {
            if (_Content >= _Capacity)
            {
                if (_Content > _Capacity)
                {
                    Overflowing(this);
                }
            }
        }

        protected virtual EventArgs Overflowing (BucketBase bucket)
        {
            throw new NotImplementedException();
        }

        protected virtual EventArgs OverFlowed (BucketBase bucket)
        {
            throw new NotImplementedException();
        }
    }
}
