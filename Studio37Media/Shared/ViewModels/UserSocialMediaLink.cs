using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class UserSocialMediaLink
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        [Required]
        [StringLength(450)]
        public string Link { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

   //     public virtual Profile Profile { get; set; }
    }
}
