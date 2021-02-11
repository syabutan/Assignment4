using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        //rank is not changable
        public Restaurant(int rank)
        {
            RestaurantRanking = rank;
        }
        //If FavoriteDish is null, it displays "It's all tasty!"
        public string? FavoriteDish { get; set; } = "It's all tasty!";
        //If Link is null, it displays "Coming soon."
        public string? Link { get; set; } = "Coming soon.";
        public int RestaurantRanking { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        public int Number { get; set; }

        //List of top 5 restaurant
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Brick Oven Restaurant",
                FavoriteDish = "Bbq Chicken & Pineapple",
                Address = "111 E 800 N",
                Phone = "(801) 374-8800",
                Link = "http://www.brickovenprovo.net/",
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Olive Garden Italian Restaurant﻿",
                FavoriteDish = "Shrimp Alfredo",
                Address = "504 W 2230 North",
                Phone = "(801) 377-0062",
                Link = "https://www.olivegarden.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Ruby River Steak House",
                Address = "1454 S University Ave Top Sirloin and Baby Back Ribs",
                Phone = "(801) 371-0648",
            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "Cafe Zupas",
                FavoriteDish = "Turkey Cranberry",
                Address = "408 W 2230 N",
                Phone = "(801) 377-7687",
                Link = "https://www.cafezupas.com/"
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "Burgers Supreme",
                FavoriteDish = "Bacon Cheeseburger",
                Address = "1796 N University Pkwy",
                Phone = "(801) 373-5713",
                Link = "https://www.burgerssupreme.com/"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
