using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionSystem
{
    public delegate void Notify();
    public class PhoneCall
    {
        event Notify PhoneCallEvent;

        public string Message { get; private set; }

        public void OnSubscribe()
        {
            Message = "Subscribed to Call";

        }
        public void OnUnsubscribe()
        {
            Message = "UnSubscribed to Call";
        }

        public void MakeAPhoneCall(bool notify)
        { 
           if(notify)
           {
            PhoneCallEvent += OnSubscribe;
           }
           else
           {
            PhoneCallEvent += OnUnsubscribe;
            }

            if(PhoneCallEvent != null)
            {
                PhoneCallEvent();

        }
    }
}
}
