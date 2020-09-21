
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


            PostTutorials = incomingTutorial.PostTutorials;
            TutorialCattegories = incomingTutorial.TutorialCattegories;
            TutorialComments = incomingTutorial.TutorialComments;
            TutorialPromoPhotoes = incomingTutorial.TutorialPromoPhotoes;
            TutorialPromoVideos = incomingTutorial.TutorialPromoVideos;
            TutorialRatings = incomingTutorial.TutorialRatings;
            TutorialSales = incomingTutorial.TutorialSales;
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

        public virtual ICollection<PostTutorial> PostTutorials { get; set; }

       // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual ICollection<TutorialCattegory> TutorialCattegories { get; set; }

         public virtual ICollection<TutorialComment> TutorialComments { get; set; }

        public virtual ICollection<TutorialPromoPhoto> TutorialPromoPhotoes { get; set; }

        public virtual ICollection<TutorialPromoVideo> TutorialPromoVideos { get; set; }

        public virtual ICollection<TutorialRating> TutorialRatings { get; set; }

         public virtual ICollection<TutorialSale> TutorialSales { get; set; }
    }
}
