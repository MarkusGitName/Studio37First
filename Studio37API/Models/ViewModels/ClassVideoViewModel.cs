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

            List<ClassRatingViewModel> newClassRating = new List<ClassRatingViewModel>();
            foreach (ClassRating incomingcClassRatings in incomingClassVideo.ClassRatings)
            {
                newClassRating.Add(new ClassRatingViewModel(incomingcClassRatings));
            }
            ClassRatings = newClassRating;

            List<ClassVideoCattegoryViewModel> newClassVideoCattegory = new List<ClassVideoCattegoryViewModel>();
            foreach (ClassVideoCattegory incomingClassVideoCattegories in incomingClassVideo.ClassVideoCattegories)
            {
                newClassVideoCattegory.Add(new ClassVideoCattegoryViewModel(incomingClassVideoCattegories));
            }
            ClassVideoCattegories = newClassVideoCattegory;

            List<ClassVideoCommentViewModel> newClassVideoCattegoryViewModel = new List<ClassVideoCommentViewModel>();
            foreach (ClassVideoComment incomingClassVideoComments in incomingClassVideo.ClassVideoComments)
            {
                newClassVideoCattegoryViewModel.Add(new ClassVideoCommentViewModel(incomingClassVideoComments));
            }
            ClassVideoComments = newClassVideoCattegoryViewModel;

            List<ClassVideoSaleViewModel> newClassVideoSale = new List<ClassVideoSaleViewModel>();
            foreach (ClassVideoSale incomingClassVideoSales in incomingClassVideo.ClassVideoSales)
            {
                newClassVideoSale.Add(new ClassVideoSaleViewModel(incomingClassVideoSales));
            }
            ClassVideoSales = newClassVideoSale;

            List<TutorialClassViewModel> newTutorialClass = new List<TutorialClassViewModel>();
            foreach (TutorialClass incomingTutorialClasses in incomingClassVideo.TutorialClasses)
            {
                newTutorialClass.Add(new TutorialClassViewModel(incomingTutorialClasses));
            }
            TutorialClasses = newTutorialClass;
            
            List<PostClassVideo> newPostClassVideo = new List<PostClassVideo>();
            foreach (TutorialClass incomingTutorialClasses in incomingClassVideo.TutorialClasses)
            {
                newTutorialClass.Add(new TutorialClassViewModel(incomingTutorialClasses));
            }
            TutorialClasses = newTutorialClass;
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

        public virtual List<ClassRatingViewModel> ClassRatings { get; set; }

        public virtual List<ClassVideoCattegoryViewModel> ClassVideoCattegories { get; set; }


        public virtual List<PostClassVideo> PostClassVideo { get; set; }
        
        public virtual List<ClassVideoCommentViewModel> ClassVideoComments { get; set; }

        public virtual List<ClassVideoSaleViewModel> ClassVideoSales { get; set; }

        public virtual List<TutorialClassViewModel> TutorialClasses { get; set; }
    }
}
