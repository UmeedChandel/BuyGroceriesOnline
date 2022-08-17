namespace BuyGroceriesOnline.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Feedback InsertFeedback(Feedback feedback)
        {
            
            var insert = this.appDbContext.Feedbacks.Add(feedback);
            this.appDbContext.SaveChanges();
            return insert.Entity;
            
           // throw new NotImplementedException();
        }
    }
}
