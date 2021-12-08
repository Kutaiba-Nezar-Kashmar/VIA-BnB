﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEP3T2GraphQL.Models;
using SEP3T2GraphQL.Repositories;
using SEP3T2GraphQL.Services.Validation;

namespace SEP3T2GraphQL.Services.Impl
{
    public class GuestReviewService : IGuestReviewService
    {
        private readonly IGuestReviewHostRepository _guestReviewRepository;
        private readonly CreateGuestReviewValidation _createGuestReviewValidation;

        public GuestReviewService(IGuestReviewHostRepository guestReviewHostRepository, CreateGuestReviewValidation createGuestReviewValidation)
        {
            _guestReviewRepository = guestReviewHostRepository;
            _createGuestReviewValidation = createGuestReviewValidation;
        }

        public async Task<GuestReview> CreateGuestReviewAsync(GuestReview guestReview)
        {
            if (guestReview == null)
            {
                throw new ArgumentException("guestReview is required");
            }
            _createGuestReviewValidation.ValidateGuestReview(guestReview);
            var guestReviews = await _guestReviewRepository.GetAllGuestReviewsByHostIdAsync(guestReview.HostId);
            
            // Updates review if host already have an HostReview for the guest. 
            if (guestReviews.Where(h => h.GuestId == guestReview.GuestId && h.HostId == guestReview.HostId).ToList().Any())
            {
                var updatedReview = await _guestReviewRepository.UpdateGuestReviewAsync(guestReview);
                return updatedReview;
            }

            return await _guestReviewRepository.CreateGuestReviewAsync(guestReview);
        }

        public async Task<GuestReview> UpdateGuestReviewAsync(GuestReview guestReview)
        {
            return await _guestReviewRepository.UpdateGuestReviewAsync(guestReview);
        }

        public async Task<IEnumerable<GuestReview>> GetAllGuestReviewsByHostIdAsync(int id)
        {
            return await _guestReviewRepository.GetAllGuestReviewsByHostIdAsync(id);
        }
    }
}