using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profile()
        {
            ClassRatings = new HashSet<ClassRating>();
            Comments = new HashSet<Comment>();
            Events = new HashSet<Event>();
            EventUsers = new HashSet<EventUser>();
            Groups = new HashSet<Group>();
            Likes = new HashSet<Like>();
            LiveShowViews = new HashSet<LiveShowView>();
            Messages = new HashSet<Message>();
            Payments = new HashSet<Payment>();
            Sales = new HashSet<Sale>();
            TutorialRatings = new HashSet<TutorialRating>();
            UserCattegories = new HashSet<UserCattegory>();
            UserChats = new HashSet<UserChat>();
            UserSocialMediaLinks = new HashSet<UserSocialMediaLink>();
            Profile1 = new HashSet<Profile>();
            Profiles = new HashSet<Profile>();
            Groups1 = new HashSet<Group>();
            Likes1 = new HashSet<Like>();
        }

        [Key]
        [StringLength(450)]
        public string UserID { get; set; }

        [Required]
        [StringLength(150)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(150)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(450)]
        public string ProfilePhoto { get; set; }

        [Required]
        [StringLength(150)]
        public string Country { get; set; }

        [Required]
        [StringLength(450)]
        public string WallPhoto { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Bio { get; set; }

        [Required]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Website { get; set; }

        public virtual ICollection<ClassRating> ClassRatings { get; set; }

         public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual ICollection<EventUser> EventUsers { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

          public virtual ICollection<Like> Likes { get; set; }

        public virtual ICollection<LiveShowView> LiveShowViews { get; set; }

         public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

         public virtual ICollection<Sale> Sales { get; set; }

         public virtual ICollection<TutorialRating> TutorialRatings { get; set; }

        public virtual ICollection<UserCattegory> UserCattegories { get; set; }

       public virtual ICollection<UserChat> UserChats { get; set; }

        public virtual ICollection<UserSocialMediaLink> UserSocialMediaLinks { get; set; }

        public virtual ICollection<Profile> Profile1 { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }

        public virtual ICollection<Group> Groups1 { get; set; }

        public virtual ICollection<Like> Likes1 { get; set; }
    }
}
