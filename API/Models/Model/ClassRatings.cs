using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class ClassRatings
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("ClassVideoID")]
        public Guid ClassVideoId { get; set; }
        public int? Rating { get; set; }

        [ForeignKey(nameof(ClassVideoId))]
        [InverseProperty("ClassRatings")]
        public virtual ClassVideo ClassVideo { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.ClassRatings))]
        public virtual Profile User { get; set; }
    }
}
