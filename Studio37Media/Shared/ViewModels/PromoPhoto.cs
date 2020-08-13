using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PromoPhotos")]
    public partial class PromoPhoto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PromoPhoto()
        {
            TutorialPromoPhotoes = new HashSet<TutorialPromoPhoto>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string PhotoPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialPromoPhoto> TutorialPromoPhotoes { get; set; }
    }
}
