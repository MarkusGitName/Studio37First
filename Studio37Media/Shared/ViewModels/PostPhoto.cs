using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PostPhotos")]
    public partial class PostPhoto
    {
        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid PhotoID { get; set; }

        public virtual Photo Photo { get; set; }

        public virtual Post Post { get; set; }
    }
}
