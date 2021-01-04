﻿using System;
using System.Collections.Generic;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC-1
            Console.WriteLine("Product Review Management With Linq!");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 2,UserId = 2, Rating = 6, Review = "Nice", isLike = true },                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 5, Review = "Good", isLike = true },                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 5, Review = "Good", isLike = true },                new ProductReview(){ ProductId = 1,UserId = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 3,UserId = 3, Rating = 4, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 4,UserId = 4, Rating = 5, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 5,UserId = 5, Rating = 4, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 6,UserId = 6, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview(){ ProductId = 7,UserId = 7, Rating = 8, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 8,UserId = 8, Rating = 3, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 9,UserId = 9, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview(){ ProductId = 10,UserId = 10, Rating = 4, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 11,UserId = 11, Rating = 4, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 12,UserId = 12, Rating = 9, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 13,UserId = 13, Rating = 3, Review = "Nice", isLike = true },
                new ProductReview(){ ProductId = 14,UserId = 14, Rating = 3, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 15,UserId = 15, Rating = 5, Review = "Good", isLike = true },
                new ProductReview(){ ProductId = 16,UserId = 16, Rating = 2, Review = "bad", isLike = true }
            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("\nProductID " + list.ProductId + "\nUserID " + list.UserId + "\nRating " + list.Rating + "\nReview " + list.Review + "\nisLike " + list.isLike);
            }
        }
    }
}