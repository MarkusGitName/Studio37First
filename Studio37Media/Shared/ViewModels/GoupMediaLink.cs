using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class GoupMediaLink
    {
        public Guid id { get; set; }

        public Guid GroupID { get; set; }

        [Required]
        [StringLength(450)]
        public string Link { get; set; }

        public virtual Group Group { get; set; }
    }
}
