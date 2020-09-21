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

            foreach (ClassRating incomingcClassRatings in incomingClassVideo.ClassRatings)
            {
                ClassRatings.Add(new ClassRatingViewModel(incomingcClassRatings));
            }

            foreach (ClassVideoCattegory incomingClassVideoCattegory in incomingClassVideo.ClassVideoCattegories)
            {
                ClassVideoCattegories.Add(new ClassVideoCattegoryViewModel(incomingClassVideoCattegory));
            }

            foreach (ClassVideoComment incomingClassVideoComment in incomingClassVideo.ClassVideoComments)
            {
                ClassVideoComments.Add(new ClassVideoCommentViewModel(incomingClassVideoComment));
            }

            foreach(ClassVideoSale incomingClassVideoSale in incomingClassVideo.ClassVideoSales)
            {
                ClassVideoSales.Add(new ClassVideoSaleViewModel(incomingClassVideoSale));
            }

            foreach(TutorialClass incomingTutorialClass in incomingClassVideo.TutorialClasses)
            {
                TutorialClasses.Add(new TutorialClassViewModel(incomingTutorialClass));
            }
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

        public virtual ICollection<ClassRatingViewModel> ClassRatings { get; set; }

         public virtual ICollection<ClassVideoCattegoryViewModel> ClassVideoCattegories { get; set; }

        public virtual ICollection<ClassVideoCommentViewModel> ClassVideoComments { get; set; }

        public virtual ICollection<ClassVideoSaleViewModel> ClassVideoSales { get; set; }

        public virtual ICollection<TutorialClassViewModel> TutorialClasses { get; set; }
    }
}
