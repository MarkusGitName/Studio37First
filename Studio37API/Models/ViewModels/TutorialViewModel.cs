
namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TutorialViewModel
    {
        public TutorialViewModel(Tutorial incomingTutorial)
        {
            id = incomingTutorial.id;
            Title = incomingTutorial.Title;
            Desctription = incomingTutorial.Desctription;
            ProfesionalID = incomingTutorial.ProfesionalID;
            DateCreated = incomingTutorial.DateCreated;
            PriceCredits = incomingTutorial.PriceCredits;
            PriceCredits = incomingTutorial.PriceCredits;

            List<PostTutorialViewModel> newPostTutorialViewModel = new List<PostTutorialViewModel>();
            foreach(PostTutorial incomingPostTutorials in incomingTutorial.PostTutorials)
            {
                PostTutorials.Add(new PostTutorialViewModel(incomingPostTutorials));
            }
            PostTutorials = newPostTutorialViewModel;

            List<TutorialCattegoryViewModel> newTutorialcategoryViewModel = new List<TutorialCattegoryViewModel>();
            foreach(TutorialCattegory incomingTutorialCattegories in incomingTutorial.TutorialCattegories)
            {
                TutorialCattegories.Add(new TutorialCattegoryViewModel(incomingTutorialCattegories));
            }
            TutorialCattegories = newTutorialcategoryViewModel;

            List<TutorialCommentViewModel> newTutorialCommentViewModel = new List<TutorialCommentViewModel>();
            foreach(TutorialComment incomingTutorialComments in incomingTutorial.TutorialComments)
            {
                TutorialComments.Add(new TutorialCommentViewModel(incomingTutorialComments));
            }
            TutorialComments = newTutorialCommentViewModel;

            List<TutorialPromoPhotoViewModel> newTutorialPromoPhotoViewModel = new List<TutorialPromoPhotoViewModel>();
            foreach(TutorialPromoPhoto incomingTutorialPromoPhotoes in incomingTutorial.TutorialPromoPhotoes)
            {
                TutorialPromoPhotoes.Add(new TutorialPromoPhotoViewModel(incomingTutorialPromoPhotoes));
            }
            TutorialPromoPhotoes = newTutorialPromoPhotoViewModel;

            List<TutorialPromoVideoViewModel> newTutorialPromoVideoViewModel = new List<TutorialPromoVideoViewModel>();
            foreach(TutorialPromoVideo incomingTutorialPromoVideos in incomingTutorial.TutorialPromoVideos)
            {
                TutorialPromoVideos.Add(new TutorialPromoVideoViewModel(incomingTutorialPromoVideos));
            }
            TutorialPromoVideos = newTutorialPromoVideoViewModel;

            List<TutorialRatingViewModel> newTutorialRatingViewModel = new List<TutorialRatingViewModel>();
            foreach(TutorialRating incomingTutorialRatings in incomingTutorial.TutorialRatings)
            {
                TutorialRatings.Add(new TutorialRatingViewModel(incomingTutorialRatings));
            }
            TutorialRatings = newTutorialRatingViewModel;

            List<TutorialSaleViewModel> newTutorialSaleViewModel = new List<TutorialSaleViewModel>();
            foreach(TutorialSale incomingTutorialSales in incomingTutorial.TutorialSales)
            {
                TutorialSales.Add(new TutorialSaleViewModel(incomingTutorialSales));
            }
            TutorialSales = newTutorialSaleViewModel;

        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Desctription { get; set; }

        [Column(TypeName = "money")]
        public decimal PriceRand { get; set; }

        [Required]
        [StringLength(450)]
        public string ProfesionalID { get; set; }

        public DateTime DateCreated { get; set; }

        public int PriceCredits { get; set; }

        public virtual List<PostTutorialViewModel> PostTutorials { get; set; }

       // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual List<TutorialCattegoryViewModel> TutorialCattegories { get; set; }

         public virtual List<TutorialCommentViewModel> TutorialComments { get; set; }

        public virtual List<TutorialPromoPhotoViewModel> TutorialPromoPhotoes { get; set; }

        public virtual List<TutorialPromoVideoViewModel> TutorialPromoVideos { get; set; }

        public virtual List<TutorialRatingViewModel> TutorialRatings { get; set; }

         public virtual List<TutorialSaleViewModel> TutorialSales { get; set; }
    }
}
