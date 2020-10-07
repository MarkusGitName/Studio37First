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


            List<ClassRatingViewModel> newClassRatingViewModel = new List<ClassRatingViewModel>();
            foreach (ClassRating incomingClassRatings in incomingProfile.ClassRatings)
            {
                newClassRatingViewModel.Add(new ClassRatingViewModel(incomingClassRatings));
            }
            ClassRatings = newClassRatingViewModel;


            List<CommentViewModel> newCommentViewModel = new List<CommentViewModel>();
            foreach (Comment incomingComments in incomingProfile.Comments)
            {
                newCommentViewModel.Add(new CommentViewModel(incomingComments));
            }
            Comments = newCommentViewModel;


            List<EventViewModel> newEventViewModel = new List<EventViewModel>();
            foreach (Event incomingEvents in incomingProfile.Events)
            {
                newEventViewModel.Add(new EventViewModel(incomingEvents));
            }
            Events = newEventViewModel;

            List<EventUserViewModel> newEventUserViewModel = new List<EventUserViewModel>();
            foreach (EventUser incomingEventUsers in incomingProfile.EventUsers)
            {
                newEventUserViewModel.Add(new EventUserViewModel(incomingEventUsers));
            }
            EventUsers = newEventUserViewModel;


            List<GroupViewModel> newGroupViewModel = new List<GroupViewModel>();
            foreach (Group incomingGroups in incomingProfile.Groups)
            {
                newGroupViewModel.Add(new GroupViewModel(incomingGroups));
            }
            Groups = newGroupViewModel;

            List < LikeViewModel > newLikeViewModel = new List<LikeViewModel>();
            foreach (Like incomingLikes in incomingProfile.Likes)
            {
                Likes.Add(new LikeViewModel(incomingLikes));
            }
            Likes = newLikeViewModel;

            List < LiveShowViewViewModel> newLiveShowViewViewModel = new List<LiveShowViewViewModel>();
            foreach (LiveShowView incomingLiveShowViews in incomingProfile.LiveShowViews)
            {
                LiveShowViews.Add(new LiveShowViewViewModel(incomingLiveShowViews));
            }
            LiveShowViews = newLiveShowViewViewModel;

            List < MessageViewModel > newMessageViewModel = new List<MessageViewModel>();
            foreach (Message incomingMessages in incomingProfile.Messages)
            {
                Messages.Add(new MessageViewModel(incomingMessages));
            }
            Messages = newMessageViewModel;

            List < PaymentViewModel> newPaymentViewModel = new List<PaymentViewModel>();
            foreach (Payment incomingPayments in incomingProfile.Payments)
            {
                Payments.Add(new PaymentViewModel(incomingPayments));
            }
            Payments = newPaymentViewModel;

            List < SaleViewModel > newSaleViewModel = new List<SaleViewModel>();
            foreach (Sale incomingSales in incomingProfile.Sales)
            {
                Sales.Add(new SaleViewModel(incomingSales));
            }
            Sales = newSaleViewModel;

            List < TutorialRatingViewModel > newTutorialRatingViewModel = new List<TutorialRatingViewModel>();
            foreach (TutorialRating incomingTutorialRatings in incomingProfile.TutorialRatings)
            {
                TutorialRatings.Add(new TutorialRatingViewModel(incomingTutorialRatings));
            }
            TutorialRatings = newTutorialRatingViewModel;

            List<UserCattegoryViewModel> newUserCattegoryViewModel = new List<UserCattegoryViewModel>();
            foreach(UserCattegory incomingUserCattegories in incomingProfile.UserCattegories)
            {
                newUserCattegoryViewModel.Add(new UserCattegoryViewModel(incomingUserCattegories));
            }
            UserCattegories= newUserCattegoryViewModel;

            List < UserChatViewModel> newUserChatViewModel = new List<UserChatViewModel>();
            foreach (UserChat incomingUserChats in incomingProfile.UserChats)
            {
                UserChats.Add(new UserChatViewModel(incomingUserChats));
            }
            UserChats = newUserChatViewModel;

            List < UserSocialMediaLinkViewModel> newUserSocialMediaLinkViewModel = new List<UserSocialMediaLinkViewModel>();
            foreach (UserSocialMediaLink incomingUserSocialMediaLinks in incomingProfile.UserSocialMediaLinks)
            {
                UserSocialMediaLinks.Add(new UserSocialMediaLinkViewModel(incomingUserSocialMediaLinks));
            }
            UserSocialMediaLinks = newUserSocialMediaLinkViewModel;

            List < ProfileViewModel> newProfileViewModel = new List<ProfileViewModel>();
            foreach (Profile incomingProfile1 in incomingProfile.Profile1)
            {
                Profile1.Add(new ProfileViewModel(incomingProfile1));
            }
            Profile1 = newProfileViewModel;

            List < ProfileViewModel > newProfilesViewModel = new List<ProfileViewModel>();
            foreach (Profile incomingProfiles in incomingProfile.Profiles)
            {
                Profiles.Add(new ProfileViewModel(incomingProfiles));
            }
            Profiles = newProfilesViewModel;

            List < GroupViewModel > newGroup1ViewModel = new List<GroupViewModel>();
            foreach (Group incomingGroups1 in incomingProfile.Groups1)
            {
                Groups1.Add(new GroupViewModel(incomingGroups1));
            }
            Groups1 = newGroup1ViewModel;

            List < LikeViewModel > newLike1ViewModel = new List<LikeViewModel>();
            foreach (Like incomingLikes1 in incomingProfile.Likes1)
            {
                Likes1.Add(new LikeViewModel(incomingLikes1));
            }
            Likes1 = newLike1ViewModel;
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

        public virtual List<ClassRatingViewModel> ClassRatings { get; set; }

        public virtual List<CommentViewModel> Comments { get; set; }

        public virtual List<EventViewModel> Events { get; set; }

        public virtual List<EventUserViewModel> EventUsers { get; set; }

        public virtual List<GroupViewModel> Groups { get; set; }

        public virtual List<LikeViewModel> Likes { get; set; }

        public virtual List<LiveShowViewViewModel> LiveShowViews { get; set; }

        public virtual List<MessageViewModel> Messages { get; set; }

        public virtual List<PaymentViewModel> Payments { get; set; }

        // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual List<SaleViewModel> Sales { get; set; }

        public virtual List<TutorialRatingViewModel> TutorialRatings { get; set; }

        public virtual List<UserCattegoryViewModel> UserCattegories { get; set; }

        public virtual List<UserChatViewModel> UserChats { get; set; }

        public virtual List<UserSocialMediaLinkViewModel> UserSocialMediaLinks { get; set; }

        public virtual List<ProfileViewModel> Profile1 { get; set; }

        public virtual List<ProfileViewModel> Profiles { get; set; }

        public virtual List<GroupViewModel> Groups1 { get; set; }

        public virtual List<LikeViewModel> Likes1 { get; set; }
    }
}
