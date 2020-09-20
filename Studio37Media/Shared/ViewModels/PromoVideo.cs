using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PromoVideo
    {
        public PromoVideo()
        {
            TutorialPromoVideos = new HashSet<TutorialPromoVideo>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string VideoPath { get; set; }

        public virtual ICollection<TutorialPromoVideo> TutorialPromoVideos { get; set; }
    }
}
