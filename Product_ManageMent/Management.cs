using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
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
        public void RetriveCount(List<ProductReview> ListProductReview)
        {
            var RetriveCount = ListProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var list in RetriveCount)
            {
                Console.WriteLine(list.ProductId + " -----" + list.Count);
            }
        }
        public void RetrieveProductAndReview(List<ProductReview> ListProductReview)
        {
            var RetrieveProductAndReview = from productReviews in ListProductReview
                                           select new { productReviews.ProductId, productReviews.Review };
            foreach (var list in RetrieveProductAndReview)
            {
                Console.WriteLine("ProductId" + " " + list.ProductId + " " + "Review" + " " + list.Review);
            }
        }
        public void SkipRecord(List<ProductReview> ListProductReview)
        {
            var SkipRecord = (from productReviews in ListProductReview
                              orderby productReviews.ProductId, productReviews.UserId, productReviews.Rating, productReviews.Review, productReviews.islike descending
                              select productReviews).Skip(5);
            foreach (var list in SkipRecord)
            {
                Console.WriteLine("ProductID:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + " " + list.Rating + " " + "Review:-" + list.Review + " " + "islike:-" + list.islike);
            }
        }
        public void AddToDataTableDemo(List<ProductReview> listProductReviews)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductId");
            table.Columns.Add("UserId");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("IsLike");
            foreach (ProductReview product in listProductReviews)
            {
                table.Rows.Add(product.ProductId, product.UserId, product.Rating, product.Review, product.islike);
            }
        }
    }
}