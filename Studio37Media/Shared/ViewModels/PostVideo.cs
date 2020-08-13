using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PostVideo")]
    public partial class PostVideo
    {
        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid VideoID { get; set; }

        public virtual Post Post { get; set; }

        public virtual Video Video { get; set; }
    }
}
