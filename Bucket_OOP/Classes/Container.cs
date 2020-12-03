using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bucket_OOP.Classes
{
    public abstract class Container
    {
        #region
        public int _Capacity { get; set; }
        public int _Content { get; set; }
        public bool _IsOverflowed { get; set; }

        private delegate void CapacityReached(Container container);
        #endregion

        

        protected Container()
        {
        }

        protected Container(int content)
        {
            this._Content = content;
        }
        protected Container(int content, int capacity)
        {
            this._Content = content;
            this._Capacity = capacity;
        }

        public virtual void fill(int amount)
        {
            if (_Content + amount <= _Capacity && _Content + amount >= 0)
            {
                _Content += amount;
            }
            else
            {
                _Content += amount;
                Full();
            }
        }

        public virtual void fill(Container bucket)
        {
            int Amount = bucket._Content;
            if (_Content + Amount <= _Capacity && _Content + Amount >= 0)
            {
                _Content += Amount;
                fill(Amount);
            }
            else
            {
                _Content += Amount;
                fill(Amount);
                Full();
            }
            
        }

        public virtual void Full()
        {
            CapacityReached reached = EventA.Overflowing;

            if (_Content > _Capacity)
            {
                reached(this);
            }
        }

        public virtual void Empty()
        {
            _Content = 0;
        }

        public virtual void Empty(int amount)
        {
            _Content -= amount;
            if (_Content <= 0)
            {
                _Content = 0;
            }
        }
    }
}
