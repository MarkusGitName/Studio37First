using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class TutorialPromoPhoto
    {
        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid PromoPhotoID { get; set; }

        public virtual PromoPhoto PromoPhoto { get; set; }

        public virtual Tutorial Tutorial { get; set; }
    }
}
