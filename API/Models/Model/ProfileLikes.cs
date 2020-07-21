using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class ProfileLikes
    {
        [Key]
        public string UserId { get; set; }
        [Key]
        public Guid LikeId { get; set; }

        [ForeignKey(nameof(LikeId))]
        [InverseProperty("ProfileLikes")]
        public virtual Like Like { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.ProfileLikes))]
        public virtual Profile User { get; set; }
    }
}
