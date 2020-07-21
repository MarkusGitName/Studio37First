using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Share
    {
        public Share()
        {
            ShareLikes = new HashSet<ShareLikes>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        public Guid? PostId { get; set; }
        [Column("caption")]
        [StringLength(450)]
        public string Caption { get; set; }
        [Column("text", TypeName = "text")]
        public string Text { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("Share")]
        public virtual Post Post { get; set; }
        [InverseProperty("Share")]
        public virtual ICollection<ShareLikes> ShareLikes { get; set; }
    }
}
