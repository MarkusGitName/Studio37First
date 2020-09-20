using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PostCattegory
    {
        public Guid id { get; set; }

        public Guid PostID { get; set; }

        [Required]
        [StringLength(125)]
        public string CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Post Post { get; set; }
    }
}
