namespace BuyGroceriesOnline.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAllFeedback();
        Feedback InsertFeedback(Feedback feedback);
        Feedback DeleteFeedback(int feedbackId);
        Feedback FeedbackDetails(int feedbackId);
    }
}
