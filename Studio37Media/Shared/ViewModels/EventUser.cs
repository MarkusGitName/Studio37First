using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class EventUser
    {
        public Guid id { get; set; }

        public Guid EventID { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public virtual Event Event { get; set; }

       // public virtual Profile Profile { get; set; }
    }
}
