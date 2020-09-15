using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PostComment
    {
        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid CommentID { get; set; }

        public virtual Comment Comment { get; set; }

        public virtual Post Post { get; set; }
    }
}
