namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ProductReview> productreviewList = new List<ProductReview>
            {
                new ProductReview() { ProductId=1,UserId=1,Rating = 5,Review="Good",islike=true },
                new ProductReview() { ProductId=2,UserId=1,Rating = 4,Review="Good",islike=true },
                new ProductReview() { ProductId=3,UserId=2,Rating = 2,Review="bad",islike=false },
                new ProductReview() { ProductId=5,UserId=2,Rating = 1,Review="bad",islike=false },
                new ProductReview() { ProductId=6,UserId=3,Rating = 1,Review="bad",islike=false },
                new ProductReview() { ProductId=1,UserId=4,Rating = 5,Review="Good",islike=true },
                new ProductReview() { ProductId=11,UserId=3,Rating = 4,Review="Good",islike=true },
                new ProductReview() { ProductId=10,UserId=10,Rating = 4,Review="Good",islike=true },
                new ProductReview() { ProductId=12,UserId=10,Rating = 4,Review="Good",islike=true },
                new ProductReview() { ProductId=13,UserId=10,Rating = 5,Review="Good",islike=true },
                new ProductReview() { ProductId=14,UserId=10,Rating = 4,Review="Good",islike=true },
                new ProductReview() { ProductId=15,UserId=10,Rating = 5,Review="Good",islike=true }
                

            };
            Management management = new Management();
            // management.TopRecords(productreviewList);
            //management.SelectRecords(productreviewList);
            management.RetrieveCountOfRecord(productreviewList);
        }
    }
}