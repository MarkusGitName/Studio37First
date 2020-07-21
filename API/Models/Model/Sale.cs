using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Sale
    {
        public Sale()
        {
            ClassVideoSale = new HashSet<ClassVideoSale>();
            TutorialSale = new HashSet<TutorialSale>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [Column("ProfesionalID")]
        [StringLength(450)]
        public string ProfesionalId { get; set; }
        [Required]
        [Column("BuyerID")]
        [StringLength(450)]
        public string BuyerId { get; set; }
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public int Credits { get; set; }

        [ForeignKey(nameof(BuyerId))]
        [InverseProperty(nameof(Profile.Sale))]
        public virtual Profile Buyer { get; set; }
        [ForeignKey(nameof(ProfesionalId))]
        [InverseProperty(nameof(ProfesionallsProfile.Sale))]
        public virtual ProfesionallsProfile Profesional { get; set; }
        [InverseProperty("Sale")]
        public virtual ICollection<ClassVideoSale> ClassVideoSale { get; set; }
        [InverseProperty("Sale")]
        public virtual ICollection<TutorialSale> TutorialSale { get; set; }
    }
}
