namespace Studio37API.Models.TempModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tutorial")]
    public partial class Tutorial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tutorial()
        {
            TutorialCattegories = new HashSet<TutorialCattegory>();
            TutorialPromoPhotoes = new HashSet<TutorialPromoPhoto>();
            TutorialPromoVideos = new HashSet<TutorialPromoVideo>();
            TutorialRatings = new HashSet<TutorialRating>();
            TutorialSales = new HashSet<TutorialSale>();
        }

        public Guid id { get; set; }

        [StringLength(450)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Desctription { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(450)]
        public string ProfesionalID { get; set; }

        public DateTime? DateCreated { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialCattegory> TutorialCattegories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialPromoPhoto> TutorialPromoPhotoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialPromoVideo> TutorialPromoVideos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialRating> TutorialRatings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialSale> TutorialSales { get; set; }
    }
}
