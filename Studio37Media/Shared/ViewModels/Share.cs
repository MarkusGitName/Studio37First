using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Share")]
    public partial class Share
    {
        public Share()
        {
            Likes = new HashSet<Like>();
        }

        public Guid id { get; set; }

        public Guid PostId { get; set; }

        [Required]
        [StringLength(450)]
        public string caption { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string text { get; set; }

        public DateTime date { get; set; }

        public virtual Post Post { get; set; }

       public virtual ICollection<Like> Likes { get; set; }
    }
}
