using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tutorial")]
    public partial class Tutorial
    {
        public Tutorial()
        {
            PostTutorials = new HashSet<PostTutorial>();
            TutorialCattegories = new HashSet<TutorialCattegory>();
            TutorialComments = new HashSet<TutorialComment>();
            TutorialPromoPhotoes = new List<TutorialPromoPhoto>();
            TutorialPromoVideos = new List<TutorialPromoVideo>();
            TutorialRatings = new HashSet<TutorialRating>();
            TutorialSales = new HashSet<TutorialSale>();
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

        [StringLength(450)]
        public string ProfesionalID { get; set; }

        public DateTime DateCreated { get; set; }

        public int PriceCredits { get; set; }

        public virtual ICollection<PostTutorial> PostTutorials { get; set; }

        public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual ICollection<TutorialCattegory> TutorialCattegories { get; set; }

       public virtual ICollection<TutorialComment> TutorialComments { get; set; }

        public virtual List<TutorialPromoPhoto> TutorialPromoPhotoes { get; set; }

        public virtual List<TutorialPromoVideo> TutorialPromoVideos { get; set; }

         public virtual ICollection<TutorialRating> TutorialRatings { get; set; }

       public virtual ICollection<TutorialSale> TutorialSales { get; set; }
    }
}
