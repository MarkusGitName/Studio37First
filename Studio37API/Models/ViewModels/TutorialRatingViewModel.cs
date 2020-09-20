namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TutorialRatingViewModel
    {
        public TutorialRatingViewModel(TutorialRating incomingTutorialRating)
        {
            id = incomingTutorialRating.id;
            UserId = incomingTutorialRating.UserId;
            Rating = incomingTutorialRating.Rating;

        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public Guid TutorialID { get; set; }

        public int Rating { get; set; }

        // public virtual Profile Profile { get; set; }

        // public virtual Tutorial Tutorial { get; set; }
    }
}
