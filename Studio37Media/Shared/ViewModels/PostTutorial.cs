using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PostTutorial
    {
        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid TutorialID { get; set; }

        public virtual Post Post { get; set; }

        public virtual Tutorial Tutorial { get; set; }
    }
}
