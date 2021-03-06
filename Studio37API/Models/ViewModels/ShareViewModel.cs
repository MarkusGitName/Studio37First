namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShareViewModel
    {
        public ShareViewModel(Share incomingShare)
        {
            id = incomingShare.id;
            PostId = incomingShare.PostId;
            caption = incomingShare.caption;
            text = incomingShare.text;
            date = incomingShare.date;

            List<LikeViewModel> newLikeViewModel = new List<LikeViewModel>();
            foreach (Like incomingLikes in incomingShare.Likes)
            {
                Likes.Add(new LikeViewModel(incomingLikes));
            }
            Likes = newLikeViewModel;

        }

        public Guid id { get; set; }

        public Guid PostId { get; set; }

        [Required]
        [StringLength(450)]
        public string caption { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string text { get; set; }

        public DateTime date { get; set; }

        // public virtual Post Post { get; set; }

        public virtual List<LikeViewModel> Likes { get; set; }
    }
}
