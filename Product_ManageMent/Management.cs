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
    }
}