using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20thDec
{
    internal class MenuCard
    {
        public enum Day
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY

        }

        public static void Run()
        {
            Console.WriteLine("Enter day number (0 = Monday, 6 = Sunday): ");
            int dayNum = int.Parse(Console.ReadLine());

            Day thisday = (Day)dayNum;
            switch (thisday)
            {
                case Day.MONDAY: 
                    Console.WriteLine("Dosa"); Console.WriteLine("Idly"); Console.WriteLine("Poori"); Console.WriteLine("Rice-bath"); 
                    break;
                case Day.TUESDAY: 
                    Console.WriteLine("Pasta"); Console.WriteLine("Butter Paneer"); Console.WriteLine("Garlic Naan"); Console.WriteLine("Veggi-Rice"); 
                    break;
                case Day.WEDNESDAY:
                    Console.WriteLine("Pizza"); Console.WriteLine("Malai Kofta"); Console.WriteLine("Tandoori Roti"); Console.WriteLine("Fruit Custard"); 
                    break;
                case Day.THURSDAY: 
                    Console.WriteLine("Noodles"); Console.WriteLine("Kathi Roll"); Console.WriteLine("Kabab"); Console.WriteLine("Marshmello Churro"); 
                    break;
                case Day.FRIDAY: 
                    Console.WriteLine("Momos"); Console.WriteLine("Rasam"); Console.WriteLine("Soya Chap"); Console.WriteLine("Amritsari Kulcha"); 
                    break;
                case Day.SATURDAY:
                    Console.WriteLine("Chole Bhature");Console.WriteLine("Paneer Tikka");Console.WriteLine("Butter Roti");Console.WriteLine("Sweet Lassi");
                    break;
                case Day.SUNDAY: Console.WriteLine("MixFruit Salad"); Console.WriteLine("Biryani"); Console.WriteLine("Raita"); Console.WriteLine("Italian Salad"); break;
                    
                default: Console.WriteLine("No Menu Available"); 
                    break;
            }
            


        }
    }
