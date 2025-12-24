// See https://aka.ms/new-console-template for more information
using Subscription;

class Program
{
    static void Main(string[] args)
    {
        PhoneCall phoneCall = new PhoneCall();
        // Subscribe to phone call notifications
        phoneCall.MakeAPhoneCall(true);
        Console.WriteLine(phoneCall.Message); // Output: Subscribed to calls
        // Unsubscribe from phone call notifications
        phoneCall.MakeAPhoneCall(false);
        Console.WriteLine(phoneCall.Message); // Output: UnSubscribed to calls
    }
}
