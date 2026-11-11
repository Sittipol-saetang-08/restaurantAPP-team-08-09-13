using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantAPP_team_08_09_13
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "KFC", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "MK", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "Fuji", Type = "Japanese", Rating = 4.8 },
        new Restaurant { Name = "Tee Noi", Type = "Suki TeeNoi", Rating = 4.5 },
        new Restaurant { Name = "Sushiro", Type = "Sushiro", Rating = 5.0 },
        new Restaurant { Name = "BBQ", Type = "Barbecue", Rating = 4.9 }
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            Console.WriteLine("Not completed");
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("===== Good Rating Restaurants =====");

            foreach (Restaurant r in restaurants)
            {
                if (r.Rating >= 4.5)
                {
                    Console.WriteLine("Name:" + r.Name);
                    Console.WriteLine("Type:" + r.Type);
                    Console.WriteLine("Rating:" + r.Rating);
                    Console.WriteLine("--------------------");
                }
            }
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            if (restaurants.Count == 0)
            {
                Console.WriteLine("No restaurant data available.");
                return;
            }

            // ค้นหาร้านที่มีคะแนนสูงสุด
            var highestRated = restaurants
                .OrderByDescending(r => r.Rating)
                .First();

            // ค้นหาร้านที่มีคะแนนต่ำสุด
            var lowestRated = restaurants
                .OrderBy(r => r.Rating)
                .First();

            Console.WriteLine("\n===== Restaurant Summary =====");

            Console.WriteLine("\nHighest Rated Restaurant");
            Console.WriteLine("Name: " + highestRated.Name);
            Console.WriteLine("Type: " + highestRated.Type);
            Console.WriteLine("Rating: " + highestRated.Rating);

            Console.WriteLine("\nLowest Rated Restaurant");
            Console.WriteLine("Name: " + lowestRated.Name);
            Console.WriteLine("Type: " + lowestRated.Type);
            Console.WriteLine("Rating: " + lowestRated.Rating);
        }
    }

}
