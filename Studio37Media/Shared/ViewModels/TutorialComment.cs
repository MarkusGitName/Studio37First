using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

   public partial class TutorialComment
    {
        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid CommentID { get; set; }

        public virtual Comment Comment { get; set; }

        public virtual Tutorial Tutorial { get; set; }
    }
}
