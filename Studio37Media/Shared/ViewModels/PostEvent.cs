﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PostEvent")]
    public partial class PostEvent
    {
        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid EventID { get; set; }

        public virtual Event Event { get; set; }

        public virtual Post Post { get; set; }
    }
}
