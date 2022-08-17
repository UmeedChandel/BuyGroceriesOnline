using BuyGroceriesOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuyGroceriesOnline.Controllers
{
    public class OrderController : Controller
    {
        private readonly IFeedbackRepository FeedbackRepository;
        public OrderController(IFeedbackRepository FeedbackRepository)
        {
            this.FeedbackRepository = FeedbackRepository;
        }

        public ViewResult FeedBack()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeedBack(Feedback feed)
        {           
            FeedbackRepository.InsertFeedback(feed);
            return RedirectToAction("Index", "Home", new { area = "" });            
        }
    }
}
