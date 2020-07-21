using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Profile
    {
        public Profile()
        {
            ClassRatings = new HashSet<ClassRatings>();
            EventUsers = new HashSet<EventUsers>();
            Events = new HashSet<Events>();
            FollowingsFollowersNavigation = new HashSet<Followings>();
            FollowingsFollowingNavigation = new HashSet<Followings>();
            GroupUser = new HashSet<GroupUser>();
            Groups = new HashSet<Groups>();
            Messages = new HashSet<Messages>();
            ProfileLikes = new HashSet<ProfileLikes>();
            Sale = new HashSet<Sale>();
            TutorialRating = new HashSet<TutorialRating>();
            UserCattegory = new HashSet<UserCattegory>();
            UserChat = new HashSet<UserChat>();
            UserSocialMediaLinks = new HashSet<UserSocialMediaLinks>();
        }

        [Key]
        [Column("UserID")]
        public string UserId { get; set; }
        [Required]
        [StringLength(150)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(150)]
        public string LastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }
        [StringLength(450)]
        public string ProfilePhoto { get; set; }
        [StringLength(150)]
        public string Country { get; set; }
        [StringLength(450)]
        public string WallPhoto { get; set; }
        [StringLength(1000)]
        public string Bio { get; set; }
        public int? PhoneNumber { get; set; }
        [StringLength(50)]
        public string Website { get; set; }

        [InverseProperty("User")]
        public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<ClassRatings> ClassRatings { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<EventUsers> EventUsers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Events> Events { get; set; }
        [InverseProperty(nameof(Followings.FollowersNavigation))]
        public virtual ICollection<Followings> FollowingsFollowersNavigation { get; set; }
        [InverseProperty(nameof(Followings.FollowingNavigation))]
        public virtual ICollection<Followings> FollowingsFollowingNavigation { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<GroupUser> GroupUser { get; set; }
        [InverseProperty("Owner")]
        public virtual ICollection<Groups> Groups { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Messages> Messages { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<ProfileLikes> ProfileLikes { get; set; }
        [InverseProperty("Buyer")]
        public virtual ICollection<Sale> Sale { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<TutorialRating> TutorialRating { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserCattegory> UserCattegory { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserChat> UserChat { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserSocialMediaLinks> UserSocialMediaLinks { get; set; }
    }
}
