namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserSocialMediaLinkViewModel
    {
        public UserSocialMediaLinkViewModel(UserSocialMediaLink incomingUserSocialMediaLink)
        {
            id = incomingUserSocialMediaLink.id;
            UserId = incomingUserSocialMediaLink.UserId;
            Link = incomingUserSocialMediaLink.Link;
            Title = incomingUserSocialMediaLink.Title;
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        [Required]
        [StringLength(450)]
        public string Link { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        // public virtual Profile Profile { get; set; }
    }
}
