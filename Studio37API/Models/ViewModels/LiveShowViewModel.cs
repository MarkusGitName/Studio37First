namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LiveShowViewModel
    {
        public LiveShowViewModel(LiveShow incomingLiveShow)
        {
            id = incomingLiveShow.id;
            UserID = incomingLiveShow.UserID;
            StartTime = incomingLiveShow.StartTime;
            EndTime = incomingLiveShow.EndTime;
            PriceRand = incomingLiveShow.PriceRand;
            PriceCredits = incomingLiveShow.PriceCredits;
            Description = incomingLiveShow.Description;
            Title = incomingLiveShow.Title;

       
            LiveShowCattegories = new HashSet<LiveShowCattegory>();
            LiveShowComments = new HashSet<LiveShowComment>();
            LiveShowSales = new HashSet<LiveShowSale>();
            LiveShowViews = new HashSet<LiveShowView>();
            PostLiveShows = new HashSet<PostLiveShow>();
            Likes = new HashSet<Like>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [Column(TypeName = "money")]
        public decimal PriceRand { get; set; }

        public int PriceCredits { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual ICollection<LiveShowCattegory> LiveShowCattegories { get; set; }

        public virtual ICollection<LiveShowComment> LiveShowComments { get; set; }

        public virtual ICollection<LiveShowSale> LiveShowSales { get; set; }

        public virtual ICollection<LiveShowView> LiveShowViews { get; set; }

        public virtual ICollection<PostLiveShow> PostLiveShows { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
