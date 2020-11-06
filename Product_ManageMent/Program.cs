using System;
using System.Collections.Generic;
namespace Product_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {

                new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 7, Review = "Good", islike = true },
            };
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + " " + list.Rating + " " + "Review:-" + list.Review + " " + "islike:-" + list.islike);
            }
            Management management = new Management();
            management.Toprecords(productReviewList);
            //management.SelectRecords(productReviewList);
        }
    }
}