using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ClassVideoCattegory")]
    public partial class ClassVideoCattegory
    {
        public Guid ClassVideoID { get; set; }

        public Guid CattegoryID { get; set; }

        public Guid id { get; set; }

        public virtual Category Category { get; set; }

        public virtual ClassVideo ClassVideo { get; set; }
    }
}
