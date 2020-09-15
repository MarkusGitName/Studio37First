using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Photo
    {
         public Photo()
        {
            PostPhotos = new HashSet<PostPhoto>();
            Likes = new HashSet<Like>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string Path { get; set; }

      public virtual ICollection<PostPhoto> PostPhotos { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
