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
        public DataTable AddToDataTableDemo(List<ProductReview> listProductReviews)
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
            return table;
        }

        internal void RetrieveNiceReviewProductsFromDataTable(object table)
        {
            throw new NotImplementedException();
        }

        internal void GetAverageRatingByProductId(object table)
        {
            throw new NotImplementedException();
        }

        internal void RetrieveIsLikeTrueProductsFromDataTable(object table)
        {
            throw new NotImplementedException();
        }

        public void RetrieveData(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    Console.Write(row[column] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void RetrieveIsLikeTrueProductsFromDataTable(DataTable table)
        {
            var productNames = from products in table.AsEnumerable()
                               where products.Field<bool>("IsLike") == true
                               select products;
            foreach (var row in productNames)
            {
                Console.Write(row.Field<int>("ProductId") + "\t" + row.Field<int>("UserId") + "\t" + row.Field<double>("Rating") + "\t" + row.Field<string>("Review") + "\t" + row.Field<bool>("IsLike") + "\n");
            }
        }
        public void GetAverageRatingByProductId(DataTable table)
        {
            var recordedData = from products in table.AsEnumerable()
                               group products by products.Field<int>("ProductId") into g
                               select new { ProductId = g.Key, Average = g.Average(a => a.Field<double>("Rating")) };
            foreach (var row in recordedData)
            {
                Console.Write(row.ProductId + "\t" + row.Average + "\n");
            }
        }
        public void RetrieveNiceReviewProductsFromDataTable(DataTable table)
        {
            var recordedData = from products in table.AsEnumerable()
                               where products.Field<string>("Review").Contains("nice")
                               select products;
            foreach (var row in recordedData)
            {
                Console.Write(row.Field<int>("ProductId") + "\t" + row.Field<int>("UserId") + "\t" + row.Field<double>("Rating") + "\t" + row.Field<string>("Review") + "\t" + row.Field<bool>("IsLike") + "\n");
            }
        }
    }
}