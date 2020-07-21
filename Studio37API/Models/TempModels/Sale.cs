namespace Studio37API.Models.TempModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sale()
        {
            ClassVideoSales = new HashSet<ClassVideoSale>();
            TutorialSales = new HashSet<TutorialSale>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string ProfesionalID { get; set; }

        [Required]
        [StringLength(450)]
        public string BuyerID { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public int Credits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassVideoSale> ClassVideoSales { get; set; }

        public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual Profile Profile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialSale> TutorialSales { get; set; }
    }
}
