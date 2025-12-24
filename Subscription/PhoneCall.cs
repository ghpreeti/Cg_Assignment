using System;
using System.Collections.Generic;
using System.Text;

namespace Subscription
{
    public class PhoneCall
    {
        public delegate void Notify();// Delegate
        public event Notify PhoneCallEvent;// Event
        public string Message { get; private set; }// Auto-implemented property
        void OnSubscribe()
        {
            Message = "Subscribed to calls";
        }
        void OnUnSubscribe()
        {
            Message = "UnSubscribed to calls";
        }

        public void MakeAPhoneCall(bool notify)
        {
            if (notify)
            {
                PhoneCallEvent += OnSubscribe;
            }
            else
            {
                PhoneCallEvent += OnUnSubscribe;
            }

            // Trigger event
            PhoneCallEvent?.Invoke();

            // Remove subscriptions
            PhoneCallEvent -= OnSubscribe;
            PhoneCallEvent -= OnUnSubscribe;
        }
    }
}
