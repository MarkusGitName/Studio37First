using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Tutorial
    {
        public Tutorial()
        {
            TutorialCattegory = new HashSet<TutorialCattegory>();
            TutorialPromoPhoto = new HashSet<TutorialPromoPhoto>();
            TutorialPromoVideo = new HashSet<TutorialPromoVideo>();
            TutorialRating = new HashSet<TutorialRating>();
            TutorialSale = new HashSet<TutorialSale>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string Desctription { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column("ProfesionalID")]
        [StringLength(450)]
        public string ProfesionalId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }

        [InverseProperty("Tutorial")]
        public virtual ICollection<TutorialCattegory> TutorialCattegory { get; set; }
        [InverseProperty("Tutorial")]
        public virtual ICollection<TutorialPromoPhoto> TutorialPromoPhoto { get; set; }
        [InverseProperty("Tutorial")]
        public virtual ICollection<TutorialPromoVideo> TutorialPromoVideo { get; set; }
        [InverseProperty("Tutorial")]
        public virtual ICollection<TutorialRating> TutorialRating { get; set; }
        [InverseProperty("Tutorial")]
        public virtual ICollection<TutorialSale> TutorialSale { get; set; }
    }
}
