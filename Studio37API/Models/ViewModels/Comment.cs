﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Comment
    {
        public Comment()
        {
            ClassVideoComments = new HashSet<ClassVideoComment>();
            CommentComments = new HashSet<CommentComment>();
            CommentComments1 = new HashSet<CommentComment>();
            LiveShowComments = new HashSet<LiveShowComment>();
            PostComments = new HashSet<PostComment>();
            TutorialComments = new HashSet<TutorialComment>();
            Likes = new HashSet<Like>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string text { get; set; }

        public DateTime Date { get; set; }

       public virtual ICollection<ClassVideoComment> ClassVideoComments { get; set; }

        public virtual ICollection<CommentComment> CommentComments { get; set; }

        public virtual ICollection<CommentComment> CommentComments1 { get; set; }

       // public virtual Profile Profile { get; set; }

        public virtual ICollection<LiveShowComment> LiveShowComments { get; set; }

        public virtual ICollection<PostComment> PostComments { get; set; }

       public virtual ICollection<TutorialComment> TutorialComments { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
