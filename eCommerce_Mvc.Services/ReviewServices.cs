using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Mvc.DAL.Repository;
using eCommerce_Mvc.Entities.Entity;

namespace eCommerce_Mvc.Services
{
    public class ReviewServices
    {
        private readonly ReviewRepository _reviewRepository;

        public ReviewServices()
        {
            _reviewRepository = new ReviewRepository();
        }

        public void AddReviews(Reviews review)
        {
            if (review == null)
                return;

            _reviewRepository.AddReview(review);
        }
    }
}
