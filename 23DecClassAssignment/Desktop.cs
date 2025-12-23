using System;
using System.Collections.Generic;
using System.Text;

namespace _23DecClassAssignment
{
    public class Desktop : Computer
    {
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }

       

        /// <summary>
        /// Desktop Price = Processor Cost + (RamSize * Ram Price) 
        /// + (HardDiskSize * Hard Disk Price) + (GraphicCard * Graphic Card Price) 
        /// + (MonitorSize * Monitor Price) + (PowerSupplyVolt * Power Supply Volt Price);
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
        public double DesktopPriceCalculation()
        {
            double processorCost = ProcessorCost();
            double ramPrice = 200;
            double hardDiskPrice = 1500;
            double graphicCardPrice = 2500;
            double powerSupplyVoltPrice = 20;
            double monitorPrice = 250;

            return processorCost
             + (RamSize * ramPrice)
             + (HardDiskSize * hardDiskPrice)
             + (GraphicCard * graphicCardPrice)
             + (MonitorSize * monitorPrice)
             + (PowerSupplyVolt * powerSupplyVoltPrice);
        }
    }
}
