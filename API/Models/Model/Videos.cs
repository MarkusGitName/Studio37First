using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Videos
    {
        public Videos()
        {
            PostVideo = new HashSet<PostVideo>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string Path { get; set; }

        [InverseProperty("Video")]
        public virtual ICollection<PostVideo> PostVideo { get; set; }
    }
}
