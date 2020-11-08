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

                 new ProductReview() { ProductId = 1, UserId = 1, Rating = 9, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 4, UserId = 1, Rating = 3, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 5, UserId = 1, Rating = 6, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 6, UserId = 1, Rating = 4, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 7, UserId = 1, Rating = 1, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 8, UserId = 1, Rating = 4, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 9, UserId = 1, Rating = 6, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 3, UserId = 1, Rating = 6, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 4, UserId = 1, Rating = 9, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 5, UserId = 1, Rating = 10, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 6, UserId = 1, Rating = 6, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 7, UserId = 1, Rating = 5, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 6, UserId = 1, Rating = 5, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 4, UserId = 1, Rating = 8, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 4, UserId = 1, Rating = 3, Review = "Good", islike = true },
                 new ProductReview() { ProductId = 5, UserId = 1, Rating = 2, Review = "Good", islike = true },
            };
            //foreach (var list in productReviewList)
            //{
            //    Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + " " + list.Rating + " " + "Review:-" + list.Review + " " + "islike:-" + list.islike);
            //}
            Management management = new Management();
            management.Toprecords(productReviewList);
            //management.SelectRecords(productReviewList);
            management.RetriveCount(productReviewList);
            management.RetrieveProductAndReview(productReviewList);
            management.SkipRecord(productReviewList);
        }
    }
}