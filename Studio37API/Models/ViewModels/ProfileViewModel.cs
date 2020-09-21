namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProfileViewModel
    {
        public ProfileViewModel(Profile incomingProfile)
        {
            UserID = incomingProfile.UserID;
            FirstName = incomingProfile.FirstName;
            LastName = incomingProfile.LastName;
            DateOfBirth = incomingProfile.DateOfBirth;
            ProfilePhoto = incomingProfile.ProfilePhoto;
            Country = incomingProfile.Country;
            WallPhoto = incomingProfile.WallPhoto;
            Bio = incomingProfile.Bio;
            PhoneNumber = incomingProfile.PhoneNumber;
            Website = incomingProfile.Website;

            foreach(ClassRating incomingClassRatings in incomingProfile.ClassRatings)
            {
                ClassRatings.Add(new ClassRatingViewModel(incomingClassRatings));
            }

            foreach(Comment incomingComments in incomingProfile.Comments)
            {
                Comments.Add(new CommentViewModel(incomingComments));
            }

            foreach(Event incomingEvents in incomingProfile.Events)
            {
                Events.Add(new EventViewModel(incomingEvents));
            }

            foreach(EventUser incomingEventUsers in incomingProfile.EventUsers)
            {
                EventUsers.Add(new EventUserViewModel(incomingEventUsers));
            }

            foreach(Group incomingGroups in incomingProfile.Groups)
            {
                Groups.Add(new GroupViewModel(incomingGroups));
            }

            foreach(Like incomingLikes in incomingProfile.Likes)
            {
                Likes.Add(new LikeViewModel(incomingLikes));
            }

            foreach(LiveShowView incomingLiveShowViews in incomingProfile.LiveShowViews)
            {
                LiveShowViews.Add(new LiveShowViewViewModel(incomingLiveShowViews));
            }

            foreach(Message incomingMessages in incomingProfile.Messages)
            {
                Messages.Add(new MessageViewModel(incomingMessages));
            }

            foreach(Payment incomingPayments in incomingProfile.Payments)
            {
                Payments.Add(new PaymentViewModel(incomingPayments));
            }

            foreach(Sale incomingSales in incomingProfile.Sales)
            {
                Sales.Add(new SaleViewModel(incomingSales));
            }

            foreach(TutorialRating incomingTutorialRatings in incomingProfile.TutorialRatings)
            {
                TutorialRatings.Add(new TutorialRatingViewModel(incomingTutorialRatings));
            }

            foreach(UserCattegory incomingUserCattegories in incomingProfile.UserCattegories)
            {
                UserCattegories.Add(new UserCattegoryViewModel(incomingUserCattegories));
            }

            foreach(UserChat incomingUserChats in incomingProfile.UserChats)
            {
                UserChats.Add(new UserChatViewModel(incomingUserChats));
            }

            foreach(UserSocialMediaLink incomingUserSocialMediaLinks in incomingProfile.UserSocialMediaLinks)
            {
                UserSocialMediaLinks.Add(new UserSocialMediaLinkViewModel(incomingUserSocialMediaLinks));
            }

            foreach(Profile incomingProfile1 in incomingProfile.Profile1)
            {
                Profile1.Add(new ProfileViewModel(incomingProfile1));
            }

            foreach(Profile incomingProfiles in incomingProfile.Profiles)
            {
                Profiles.Add(new ProfileViewModel(incomingProfiles));
            }

            foreach(Group incomingGroups1 in incomingProfile.Groups1)
            {
                Groups1.Add(new GroupViewModel(incomingGroups1));
            }

            foreach(Like incomingLikes1 in incomingProfile.Likes1)
            {
                Likes1.Add(new LikeViewModel(incomingLikes1));
            }
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

        public virtual ICollection<ClassRatingViewModel> ClassRatings { get; set; }

        public virtual ICollection<CommentViewModel> Comments { get; set; }

        public virtual ICollection<EventViewModel> Events { get; set; }

        public virtual ICollection<EventUserViewModel> EventUsers { get; set; }

        public virtual ICollection<GroupViewModel> Groups { get; set; }

        public virtual ICollection<LikeViewModel> Likes { get; set; }

        public virtual ICollection<LiveShowViewViewModel> LiveShowViews { get; set; }

        public virtual ICollection<MessageViewModel> Messages { get; set; }

        public virtual ICollection<PaymentViewModel> Payments { get; set; }

        // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual ICollection<SaleViewModel> Sales { get; set; }

        public virtual ICollection<TutorialRatingViewModel> TutorialRatings { get; set; }

        public virtual ICollection<UserCattegoryViewModel> UserCattegories { get; set; }

        public virtual ICollection<UserChatViewModel> UserChats { get; set; }

        public virtual ICollection<UserSocialMediaLinkViewModel> UserSocialMediaLinks { get; set; }

        public virtual ICollection<ProfileViewModel> Profile1 { get; set; }

        public virtual ICollection<ProfileViewModel> Profiles { get; set; }

        public virtual ICollection<GroupViewModel> Groups1 { get; set; }

        public virtual ICollection<LikeViewModel> Likes1 { get; set; }
    }
}
