using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class PostCattegory
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("PostID")]
        public Guid PostId { get; set; }
        [Column("CategoryID")]
        [StringLength(125)]
        public string CategoryId { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty(nameof(Categories.PostCattegory))]
        public virtual Categories Post { get; set; }
        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostCattegory")]
        public virtual Post PostNavigation { get; set; }
    }
}
