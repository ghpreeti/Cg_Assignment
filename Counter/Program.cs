// See https://aka.ms/new-console-template for more information
using CounterTask;

class Program
{
    static void Main() {         
        int[] arr = { 1, 0, 0, 1, 0, 1, 1 };
        Counter counter = new Counter(arr);
        try
        {
            string result = counter.GetCount();
            Console.WriteLine(result);
        }
        catch (ExceptionZero ex)
        {
            Console.WriteLine("Caught ExceptionZero: " + ex.Message);
        }
        catch (ExceptionOne ex)
        {
            Console.WriteLine("Caught ExceptionOne: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught General Exception: " + ex.Message);
        }
    }
}
