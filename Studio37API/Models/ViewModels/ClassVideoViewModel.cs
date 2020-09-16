namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassVideoViewModel
    {
         public ClassVideoViewModel(ClassVideo incomingClassVideo)
        {
            id = incomingClassVideo.id;
            VideoPath = incomingClassVideo.VideoPath;
            PriceRand = incomingClassVideo.PriceRand;
            PriceCredits = incomingClassVideo.PriceCredits;
            DateAdded = incomingClassVideo.DateAdded;
            Title = incomingClassVideo.Title;
            Description = incomingClassVideo.Description;
            VideoThumbnail = incomingClassVideo.VideoThumbnail;

            ClassRatings = incomingClassVideo.ClassRatings;
            ClassVideoCattegories = incomingClassVideo.ClassVideoCattegories;
            ClassVideoComments = incomingClassVideo.ClassVideoComments;
            ClassVideoSales = incomingClassVideo.ClassVideoSales;
            TutorialClasses = incomingClassVideo.TutorialClasses;
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
