using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ClassVideo
    {
        public ClassVideo()
        {
            ClassRatings = new HashSet<ClassRating>();
            ClassVideoCattegories = new HashSet<ClassVideoCattegory>();
            ClassVideoComments = new HashSet<ClassVideoComment>();
            ClassVideoSales = new HashSet<ClassVideoSale>();
            TutorialClasses = new HashSet<TutorialClass>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string VideoPath { get; set; }

        [Column(TypeName = "money")]
        public decimal PriceRand { get; set; }

        public int PriceCredits { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [StringLength(450)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(450)]
        public string VideoThumbnail { get; set; }

        public virtual ICollection<ClassRating> ClassRatings { get; set; }

        public virtual ICollection<ClassVideoCattegory> ClassVideoCattegories { get; set; }

        public virtual ICollection<ClassVideoComment> ClassVideoComments { get; set; }

         public virtual ICollection<ClassVideoSale> ClassVideoSales { get; set; }

        public virtual ICollection<TutorialClass> TutorialClasses { get; set; }
    }
}
