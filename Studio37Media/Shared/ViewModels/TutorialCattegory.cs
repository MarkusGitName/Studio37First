using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class TutorialCattegory
    {
        public TutorialCattegory()
        {
            TutorialClasses = new HashSet<TutorialClass>();
        }

        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid CattegoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Tutorial Tutorial { get; set; }

       public virtual ICollection<TutorialClass> TutorialClasses { get; set; }
    }
}
