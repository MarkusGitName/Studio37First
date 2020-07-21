using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class TutorialRating
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("TutorialID")]
        public Guid? TutorialId { get; set; }
        public int? Rating { get; set; }

        [ForeignKey(nameof(TutorialId))]
        [InverseProperty("TutorialRating")]
        public virtual Tutorial Tutorial { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.TutorialRating))]
        public virtual Profile User { get; set; }
    }
}
