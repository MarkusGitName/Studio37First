using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class ProfesionallsProfile
    {
        public ProfesionallsProfile()
        {
            ProfesionalsDocuments = new HashSet<ProfesionalsDocuments>();
            Sale = new HashSet<Sale>();
            Stickers = new HashSet<Stickers>();
        }

        [Key]
        [Column("UserID")]
        public string UserId { get; set; }
        public int YearsExperience { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [StringLength(450)]
        public string Logo { get; set; }
        [StringLength(250)]
        public string ProfesionalEmail { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.ProfesionallsProfile))]
        public virtual Profile User { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<ProfesionalsDocuments> ProfesionalsDocuments { get; set; }
        [InverseProperty("Profesional")]
        public virtual ICollection<Sale> Sale { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Stickers> Stickers { get; set; }
    }
}
