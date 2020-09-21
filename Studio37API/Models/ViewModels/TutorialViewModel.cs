
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

            foreach(PostTutorial incomingPostTutorials in incomingTutorial.PostTutorials)
            {
                PostTutorials.Add(new PostTutorialViewModel(incomingPostTutorials));
            }

            foreach(TutorialCattegory incomingTutorialCattegories in incomingTutorial.TutorialCattegories)
            {
                TutorialCattegories.Add(new TutorialCattegoryViewModel(incomingTutorialCattegories));
            }

            foreach(TutorialComment incomingTutorialComments in incomingTutorial.TutorialComments)
            {
                TutorialComments.Add(new TutorialCommentViewModel(incomingTutorialComments));
            }

            foreach(TutorialPromoPhoto incomingTutorialPromoPhotoes in incomingTutorial.TutorialPromoPhotoes)
            {
                TutorialPromoPhotoes.Add(new TutorialPromoPhotoViewModel(incomingTutorialPromoPhotoes));
            }

            foreach(TutorialPromoVideo incomingTutorialPromoVideos in incomingTutorial.TutorialPromoVideos)
            {
                TutorialPromoVideos.Add(new TutorialPromoVideoViewModel(incomingTutorialPromoVideos));
            }

            foreach(TutorialRating incomingTutorialRatings in incomingTutorial.TutorialRatings)
            {
                TutorialRatings.Add(new TutorialRatingViewModel(incomingTutorialRatings));
            }

            foreach(TutorialSale incomingTutorialSales in incomingTutorial.TutorialSales)
            {
                TutorialSales.Add(new TutorialSaleViewModel(incomingTutorialSales));
            }

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

        public virtual ICollection<PostTutorialViewModel> PostTutorials { get; set; }

       // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual ICollection<TutorialCattegoryViewModel> TutorialCattegories { get; set; }

         public virtual ICollection<TutorialCommentViewModel> TutorialComments { get; set; }

        public virtual ICollection<TutorialPromoPhotoViewModel> TutorialPromoPhotoes { get; set; }

        public virtual ICollection<TutorialPromoVideoViewModel> TutorialPromoVideos { get; set; }

        public virtual ICollection<TutorialRatingViewModel> TutorialRatings { get; set; }

         public virtual ICollection<TutorialSaleViewModel> TutorialSales { get; set; }
    }
}
