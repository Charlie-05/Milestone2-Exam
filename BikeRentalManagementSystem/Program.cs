using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }

        public static void Menu()
        {
            var bike = new Bike(1, "Yamaha", "FZ", 200);
            Console.WriteLine(bike.ToString());
            var manager = new BikeManager();
            
            while (true)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Options Menu");

                Console.WriteLine("1.Add a bike");
                Console.WriteLine("2.View all bikes");
                Console.WriteLine("3.Update a bike");
                Console.WriteLine("4.Delete a bike");
                Console.WriteLine("5.Exit");
                Console.Write("Choose an Option : ");

                var MenuInput = Console.ReadLine();
                switch (MenuInput)
                {   
                    case "1":
                        manager.CreateBike();
                        break;
                    case "2":
                        manager.ReadBikes();
                        break;
                    case "3":
                        manager.UpdateBike();
                        break;
                    case "4":
                        manager.DeleteBike();
                        break;
                    case "5":
                        Console.WriteLine("Thank You!!!");
                        return;
                    default:
                        Console.Clear();
                        Menu();
                        break;
                    
                }
            }
        }

       

    }
}
