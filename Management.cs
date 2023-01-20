using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void TopRecords(List<ProductReview> reviews)
        {
            var recorddata = (from productReview in reviews orderby productReview.Rating descending select productReview).Take(3);
            foreach (var list in recorddata) 
            {
                //                new ProductReview() { ProductId=15,UserId=10,Rating = 5,Review="Good",islike=true }

                Console.WriteLine("Product ID: "+list.ProductId
                                    +" UserId: "+list.UserId
                                    +" Rating: "+list.Rating
                                    +" Review: "+list.Review);
            }
        }
        public void SelectRecords(List<ProductReview> reviews)
        {
            var recorddata = (from products in reviews
                              where (products.ProductId == 1 && products.Rating > 3) ||
                              (products.ProductId == 4 && products.Rating > 3) ||
                              (products.ProductId == 9 && products.Rating > 3)
                              select products);
            foreach(var list in recorddata)
            {
                Console.WriteLine("Product ID: " + list.ProductId
                                    + " UserId: " + list.UserId
                                    + " Rating: " + list.Rating
                                    + " Review: " + list.Review);
            }
        }
        public void RetrieveCountOfRecord(List<ProductReview> reviews)
        {
            var records=reviews.GroupBy(x=>x.ProductId).Select(x=> new {ProductId=x.Key,Count=x.Count()});
            foreach (var list in records)
            {
                Console.WriteLine("Product ID: " + list.ProductId + "---------------------------------" + " Count: " + list.Count);
                                    
                                    
            }
        }
        public void SelectProductIdRecords(List<ProductReview> reviews)
        {
           var recorddata = (from products in reviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key });
                            // select products.ProductId,products.;
            foreach (var list in recorddata)
            {
                Console.WriteLine("Product ID: " + list.ProductId
                                    + " UserId: " + list.UserId
                                    + " Rating: " + list.Rating
                                    + " Review: " + list.Review);
            }
        }
    }
}
