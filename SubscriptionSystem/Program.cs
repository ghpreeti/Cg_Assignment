// See https://aka.ms/new-console-template for more information
using System;
using SubscriptionSystem;

class Program
{
    static void Main(string[] args)
    {
        PhoneCall phoneCall = new PhoneCall();
        phoneCall.MakeAPhoneCall(true);
        Console.WriteLine(phoneCall.Message);
        phoneCall.MakeAPhoneCall(false);
        Console.WriteLine(phoneCall.Message);
    }
}
