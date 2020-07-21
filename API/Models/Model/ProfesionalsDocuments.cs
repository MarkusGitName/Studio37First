using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class ProfesionalsDocuments
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; }
        [Column(TypeName = "text")]
        public string Discription { get; set; }
        [StringLength(450)]
        public string DocumentPath { get; set; }
        public bool? VissibleToPublic { get; set; }
        public bool? VissibleToFollowers { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(ProfesionallsProfile.ProfesionalsDocuments))]
        public virtual ProfesionallsProfile User { get; set; }
    }
}
