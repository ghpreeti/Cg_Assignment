using System;

namespace LotteryManagementSystem
{
    public class CustomEventArgs : EventArgs
    {
        public int Quantity { get; set; }

        public CustomEventArgs(int quantity)
        {
            Quantity = quantity;
        }
    }
}