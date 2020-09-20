using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PostLiveShow
    {
        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid LiveShowID { get; set; }

        public virtual LiveShow LiveShow { get; set; }

        public virtual Post Post { get; set; }
    }
}
