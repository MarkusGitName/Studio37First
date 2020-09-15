using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PromoPhoto
    {
        public PromoPhoto()
        {
            TutorialPromoPhotoes = new HashSet<TutorialPromoPhoto>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string PhotoPath { get; set; }

         public virtual ICollection<TutorialPromoPhoto> TutorialPromoPhotoes { get; set; }
    }
}
