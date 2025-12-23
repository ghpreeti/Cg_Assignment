using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace _23DecClassAssignment
{
    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

                  

        /// <summary>
        /// Laptop Price = Processor Cost + (RamSize * Ram Price) 
        /// + (HardDiskSize * Hard Disk Price) + (GraphicCard * Graphic Card Price) 
        /// + (Display Size* Display Price) + (BatteryVolt * Battery Volt Price);
        /// </summary>


        //Ram price(per GB)
        //Hard disk(per TB)
        //Graphic Card(per GB)
        //Power supply(per Volt)
        //Monitor(per inch)
        //Processor Cost-i3 2500 i5-5000 i7-6500
        private double ProcessorCost()
        {
            if (Processor.Equals("i3")) return 2500;
            if (Processor.Equals("i5")) return 5000;
            if (Processor.Equals("i7")) return 6500;
            return 0;
        }
        public double LaptopPriceCalculation()
        {
            double processorCost = ProcessorCost();
            double ramPrice = 200;
            double hardDiskPrice = 1500;
            double graphicCardPrice = 2500;
            double batteryVoltPrice = 20;
            double displayPrice = 250;
           

            return processorCost
             + (RamSize * ramPrice)
             + (HardDiskSize * hardDiskPrice)
             + (GraphicCard * graphicCardPrice)
             + (DisplaySize * displayPrice)
             + (BatteryVolt * batteryVoltPrice);

        }
    }
}
