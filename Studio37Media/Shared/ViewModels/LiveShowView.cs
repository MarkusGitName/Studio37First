using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class LiveShowView
    {
        public Guid id { get; set; }

        public Guid LiveShowID { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public DateTime JoinTime { get; set; }

        public DateTime LeaveLtime { get; set; }

        public virtual LiveShow LiveShow { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
