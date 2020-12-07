using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using static Bucket_OOP.Classes.ContainerEvents;

namespace Bucket_OOP.Classes
{
    public abstract class Container
    {
        private string EventReturnString;
        #region
        protected int _capacity { get; set; }
        protected int _content { get; set; }
        protected bool _isOverflowed { get; set; }
        protected int _spilled { get; set; }
        #endregion

        protected Container()
        {
            AddEvents(this);
        }

        protected Container(int content)
        {
            AddEvents(this);
            this._content = content;
        }
        protected Container(int content, int capacity)
        {
            AddEvents(this);
            this._content = content;
            this._capacity = capacity;
        }

        public virtual void Fill(int amount)
        {
            while (_content != _content + amount)
            {
                amount--;
                _content++;

                if (_content == this._capacity)
                {
                    if (this is Bucket)
                    {
                        OnFull(new ContainerEventArgs { BucketType = this as Bucket });
                    }
                    else if (this is OilDrum)
                    {
                        OnFull(new ContainerEventArgs { OilDrumType = this as OilDrum });
                    }
                    else if (this is RainBarrelS)
                    {
                        OnFull(new ContainerEventArgs { RainBarrelSType = this as RainBarrelS });
                    }
                    else if (this is RainBarrelM)
                    {
                        OnFull(new ContainerEventArgs { RainBarrelMType = this as RainBarrelM });
                    }
                    else if (this is RainBarrelL)
                    {
                        OnFull(new ContainerEventArgs { RainBarrelLType = this as RainBarrelL });
                    }    
                }
                else if (_content >= this._capacity)
                {
                    _spilled++;
                    _isOverflowed = true;
                    if (this is Bucket)
                    {
                        OnCapacityOverflowing(new CapacityOverflowingEventArgs { DebugMessageSend = _isOverflowed, BucketType = this as Bucket });
                    }
                    else if (this is OilDrum)
                    {
                        OnCapacityOverflowing(new CapacityOverflowingEventArgs { DebugMessageSend = _isOverflowed, OilDrumType = this as OilDrum });
                    }
                    else if (this is RainBarrelS)
                    {
                        OnCapacityOverflowing(new CapacityOverflowingEventArgs { DebugMessageSend = _isOverflowed, RainBarrelSType = this as RainBarrelS });
                    }
                    else if (this is RainBarrelM)
                    {
                        OnCapacityOverflowing(new CapacityOverflowingEventArgs { DebugMessageSend = _isOverflowed, RainBarrelMType = this as RainBarrelM });
                    }
                    else if (this is RainBarrelL)
                    {
                        OnCapacityOverflowing(new CapacityOverflowingEventArgs { DebugMessageSend = _isOverflowed, RainBarrelLType = this as RainBarrelL });
                    }
                }
            }

            if (_isOverflowed)
            {
                OnCapacityOverflowed(new CapacityOverflowedEventArgs { LostAmount = _spilled, BucketType = this as Bucket });
            }
            else if (_content < _capacity)
            {
                Debug.WriteLine($"a {GetType()} is almost at its capacity : {_content * 100 / _capacity * 100 / 100}% ");
            }
        }

        public virtual void Fill(Container bucket)
        {
            int Amount;
            if (this is Bucket)
            {
                Amount = (bucket as Bucket).Content;

                while (_content != _content+Amount)
                {
                    Amount--;
                    _content++;

                    if (_content == this._capacity)
                    {
                        OnFull(new ContainerEventArgs { BucketType = this as Bucket });
                    }
                    else if (_content >= this._capacity)
                    {
                        _spilled++;
                        OnCapacityOverflowing(new CapacityOverflowingEventArgs { DebugMessageSend = _isOverflowed, BucketType = this as Bucket});
                    }
                }

                if (_isOverflowed)
                {
                    OnCapacityOverflowed(new CapacityOverflowedEventArgs { LostAmount = _spilled, BucketType = this as Bucket });
                }
                else if (_content < _capacity)
                {
                    Debug.WriteLine($"a {GetType()} is almost at its capacity : {_content * 100 / _capacity * 100 / 100}% ");
                }
            }
            else
            {
                Debug.WriteLine($"A {bucket.GetType()} is not a bucket");
            }
        }

        public virtual void Empty()
        {
            _content = 0;
            _isOverflowed = false;
            _spilled = 0;
        }

        public virtual void Empty(int amount)
        {
            _isOverflowed = false;
            if (amount > _content)
            {
                _content = 0;
            }
            else
            {
                _content -= amount;
            }
        }

        #region ContainerEvents

        public event EventHandler<ContainerEventArgs> Full;

        protected string OnFull(ContainerEventArgs e)
        {
            Full?.Invoke(this, e);
            return EventReturnString;
        }

        public event EventHandler<CapacityOverflowingEventArgs> CapacityOverflowing;

        protected string OnCapacityOverflowing(CapacityOverflowingEventArgs e)
        {
            CapacityOverflowing?.Invoke(this, e);
            return EventReturnString;
        }

        public event EventHandler<CapacityOverflowedEventArgs> CapacityOverflowed;

        protected string OnCapacityOverflowed(CapacityOverflowedEventArgs e)
        {
            CapacityOverflowed?.Invoke(this, e);
            return EventReturnString;
        }

        #endregion
    }

    public class ContainerEvents
    {
        public static void AddEvents(Container container)
        {
            container.Full += Full;
            container.CapacityOverflowing += CapacityOverflowing;
            container.CapacityOverflowed += CapacityOverflowed;
        }

        #region Event Args
        public class ContainerEventArgs : EventArgs
        {
            public Bucket BucketType { get; set; }
            public OilDrum OilDrumType { get; set; }
            public RainBarrelL RainBarrelLType { get; set; }
            public RainBarrelM RainBarrelMType { get; set; }
            public RainBarrelS RainBarrelSType { get; set; }
        }

        public class CapacityOverflowingEventArgs : ContainerEventArgs
        {
            public bool DebugMessageSend { get; set; }
        }

        public class CapacityOverflowedEventArgs : ContainerEventArgs
        {
            public int LostAmount { get; set; }
        }
        #endregion

        #region Event Methods
        public static void Full(object sender, ContainerEventArgs e)
        {
            Debug.WriteLine($"A {e.GetType()} is full, please empty that bucket before it overflows");
        }

        public static void CapacityOverflowing(object sender, CapacityOverflowingEventArgs e)
        {
            Container container = sender as Container;
            container?.Empty(1);

            // Notify that bucket is overflowing
            if (!e.DebugMessageSend)
            {
                Debug.WriteLine($"A {e.GetType()} is overflowing");
            }
        }

        public static void CapacityOverflowed(object sender, CapacityOverflowedEventArgs e)
        {
            Debug.WriteLine($"A {e.GetType()} has overflowed and lost {e.LostAmount} content");
        }
        #endregion
    }
}    


