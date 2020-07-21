using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class StickerCattegory
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("StickeID")]
        public Guid? StickeId { get; set; }
        [Column("CategoryID")]
        public Guid? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(Categories.StickerCattegory))]
        public virtual Categories Category { get; set; }
        [ForeignKey(nameof(StickeId))]
        [InverseProperty(nameof(Stickers.StickerCattegory))]
        public virtual Stickers Sticke { get; set; }
    }
}
