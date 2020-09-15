using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Video
    {
       public Video()
        {
            PostVideos = new HashSet<PostVideo>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string Path { get; set; }

       public virtual ICollection<PostVideo> PostVideos { get; set; }
    }
}
