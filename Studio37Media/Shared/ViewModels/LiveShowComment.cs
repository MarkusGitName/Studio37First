using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class LiveShowComment
    {
        public Guid id { get; set; }

        public Guid LiveShowID { get; set; }

        public Guid CommentID { get; set; }

        public virtual Comment Comment { get; set; }

        public virtual LiveShow LiveShow { get; set; }
    }
}
