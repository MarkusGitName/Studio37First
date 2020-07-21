using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Stickers
    {
        public Stickers()
        {
            StickerCattegory = new HashSet<StickerCattegory>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; }
        public int? Grade { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(ProfesionallsProfile.Stickers))]
        public virtual ProfesionallsProfile User { get; set; }
        [InverseProperty("Sticke")]
        public virtual ICollection<StickerCattegory> StickerCattegory { get; set; }
    }
}
