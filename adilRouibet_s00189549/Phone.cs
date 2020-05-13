using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace adilRouibet_s00189549
{
   public class Phone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }


        public void IncreasedPrice(decimal percentage)
        {  
            decimal percentagePriceIncrease =(Price * percentage * 0.01m);

            Price += percentagePriceIncrease;
        }
    }
}
