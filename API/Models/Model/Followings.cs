using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Followings
    {
        [Key]
        public string Followers { get; set; }
        [Key]
        public string Following { get; set; }

        [ForeignKey(nameof(Followers))]
        [InverseProperty(nameof(Profile.FollowingsFollowersNavigation))]
        public virtual Profile FollowersNavigation { get; set; }
        [ForeignKey(nameof(Following))]
        [InverseProperty(nameof(Profile.FollowingsFollowingNavigation))]
        public virtual Profile FollowingNavigation { get; set; }
    }
}
