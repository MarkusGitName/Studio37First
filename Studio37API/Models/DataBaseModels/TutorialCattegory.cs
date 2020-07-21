namespace Studio37API.Models.DataBaseModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TutorialCattegory")]
    public partial class TutorialCattegory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TutorialCattegory()
        {
            TutorialClasses = new HashSet<TutorialClass>();
        }

        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid CattegoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Tutorial Tutorial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TutorialClass> TutorialClasses { get; set; }
    }
}
