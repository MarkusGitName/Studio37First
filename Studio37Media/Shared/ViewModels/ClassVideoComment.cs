using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ClassVideoComment")]
    public partial class ClassVideoComment
    {
        public Guid id { get; set; }

        public Guid ClassVideoID { get; set; }

        public Guid CommentID { get; set; }

        public virtual ClassVideo ClassVideo { get; set; }

        public virtual Comment Comment { get; set; }
    }
}
