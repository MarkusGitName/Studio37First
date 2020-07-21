using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class TutorialCattegory
    {
        public TutorialCattegory()
        {
            TutorialClasses = new HashSet<TutorialClasses>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("TutorialID")]
        public Guid? TutorialId { get; set; }
        [Column("CattegoryID")]
        public Guid? CattegoryId { get; set; }

        [ForeignKey(nameof(CattegoryId))]
        [InverseProperty(nameof(Categories.TutorialCattegory))]
        public virtual Categories Cattegory { get; set; }
        [ForeignKey(nameof(TutorialId))]
        [InverseProperty("TutorialCattegory")]
        public virtual Tutorial Tutorial { get; set; }
        [InverseProperty("Tutorial")]
        public virtual ICollection<TutorialClasses> TutorialClasses { get; set; }
    }
}
