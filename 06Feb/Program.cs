using System;

public class Program
{
    public static Stack<Order> OrderStack { get; set; } = new Stack<Order>();
    public static void Main(string[] args)
    {
       Console.WriteLine("OrderId:"); 
       int orderId = Convert.ToInt32(Console.ReadLine()); 
       
       Console.WriteLine("Customer Name:"); 
       string customerName = Console.ReadLine(); 
       
       Console.WriteLine("Item:"); 
       string item = Console.ReadLine(); 
       
       Order order = new Order();
       order.AddOrderDetails(orderId, customerName, item);
       
       Console.WriteLine("Most Recent Order:"); 
       Console.WriteLine(order.GetOrderDetails());
       
       order.RemoveOrderDetails();
    }
    
public class Order{
    
     public int OrderId{get; set;}
     public string CustomerName{get; set;}
     public string item{set; get;}
     
     public Stack<Order> AddOrderDetails(int orderId,string customerName,string item) {
         Order newOrder = new Order { 
         OrderId = orderId, 
         CustomerName = customerName, 
         Item = item 
         }; 
         Program.OrderStack.Push(newOrder); 
         return Program.OrderStack;
        }
      
    public string GetOrderDetails() {
        if (Program.OrderStack.Count > 0) {
            Order recentOrder = Program.OrderStack.Peek();
            return $"{recentOrder.OrderId} {recentOrder.CustomerName} {recentOrder.Item}"; 
            
        } else {
            return "No orders available"; 
        } 
    }
    
    public Stack<Order> RemoveOrderDetails() {
        if (Program.OrderStack.Count > 0) {
            Program.OrderStack.Pop(); 
        } 
        return Program.OrderStack; 
    }
    
    }
}

