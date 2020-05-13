using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adilRouibet_s00189549;

namespace DatabaseCreator 
{
   public class Program 
    {
        static void Main(string[] args)
        {
            PhonesDataBase db = new PhonesDataBase();

            using (db)
            {
                Phone p1 = new Phone()
                {
                    Name = "Samsung S20",
                    Price = 500,
                    OperatingSystem = "Android",
                    OS_Image = "/images/android.png",
                    Phone_Image = "/images/s20.jpg"
                };

                Phone p2 = new Phone()
                {
                    Name = "iPhone 11",
                    Price = 600,
                    OperatingSystem = "IOS",
                    OS_Image = "/images/apple.png",
                    Phone_Image = "/images/iphone11.jpg"
                };

                db.phones.Add(p1);

                db.phones.Add(p2);

                db.SaveChanges();
            }

        }
    }
}
