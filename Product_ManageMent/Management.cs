using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
namespace Product_Management
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void Toprecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);
        }
        public void SelectRecords(List<ProductReview> ListProductReview)
        {
            var SelectRecords = from ProductReviews in ListProductReview
                                where (ProductReviews.ProductId == 1 || ProductReviews.ProductId == 4 || ProductReviews.ProductId == 9)
                                && ProductReviews.Rating > 3
                                select ProductReviews;
            foreach (var list in SelectRecords)
            {
                Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + " " + list.Rating + " " + "Review:-" + list.Review + " " + "islike:-" + list.islike);
            }
        }
    }
}