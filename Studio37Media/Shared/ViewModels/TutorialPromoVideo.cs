using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TutorialPromoVideo")]
    public partial class TutorialPromoVideo
    {
        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid PromoVideoID { get; set; }

        public virtual PromoVideo PromoVideo { get; set; }

        public virtual Tutorial Tutorial { get; set; }
    }
}
