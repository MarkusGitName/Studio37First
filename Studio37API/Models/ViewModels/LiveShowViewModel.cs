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

            foreach(LiveShowCattegory incomingLiveShowCattegories in incomingLiveShow.LiveShowCattegories)
            {
                LiveShowCattegories.Add(new LiveShowCattegoryViewModel(incomingLiveShowCattegories));
            }

            foreach(LiveShowComment incomingLiveShowComments in incomingLiveShow.LiveShowComments)
            {
                LiveShowComments.Add(new LiveShowCommentViewModel(incomingLiveShowComments));
            }
       
            foreach(LiveShowSale incomingLiveShowSales in incomingLiveShow.LiveShowSales)
            {
                LiveShowSales.Add(new LiveShowSaleViewModel(incomingLiveShowSales));
            }

            foreach(LiveShowView incomingLiveShowViews in incomingLiveShow.LiveShowViews)
            {
                LiveShowViews.Add(new LiveShowViewViewModel(incomingLiveShowViews));
            }

            foreach(PostLiveShow incomingPostLiveShows in incomingLiveShow.PostLiveShows)
            {
                PostLiveShows.Add(new PostLiveShowViewModel(incomingPostLiveShows));
            }

            foreach(Like incomingLikes in incomingLiveShow.Likes)
            {
                Likes.Add(new LikeViewModel(incomingLikes));
            }

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

        public virtual ICollection<LiveShowCattegoryViewModel> LiveShowCattegories { get; set; }

        public virtual ICollection<LiveShowCommentViewModel> LiveShowComments { get; set; }

        public virtual ICollection<LiveShowSaleViewModel> LiveShowSales { get; set; }

        public virtual ICollection<LiveShowViewViewModel> LiveShowViews { get; set; }

        public virtual ICollection<PostLiveShowViewModel> PostLiveShows { get; set; }

        public virtual ICollection<LikeViewModel> Likes { get; set; }
    }
}
