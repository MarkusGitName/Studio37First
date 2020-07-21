using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Model
{
    public partial class AdventureContext : DbContext
    {
        public AdventureContext()
        {
        }

        public AdventureContext(DbContextOptions<AdventureContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<ClassRatings> ClassRatings { get; set; }
        public virtual DbSet<ClassVideo> ClassVideo { get; set; }
        public virtual DbSet<ClassVideoCattegory> ClassVideoCattegory { get; set; }
        public virtual DbSet<ClassVideoSale> ClassVideoSale { get; set; }
        public virtual DbSet<CommentComments> CommentComments { get; set; }
        public virtual DbSet<CommentLikes> CommentLikes { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<EventGroups> EventGroups { get; set; }
        public virtual DbSet<EventUsers> EventUsers { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Followings> Followings { get; set; }
        public virtual DbSet<GoupMediaLink> GoupMediaLink { get; set; }
        public virtual DbSet<GroupUser> GroupUser { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Like> Like { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<PhotoLike> PhotoLike { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostCattegory> PostCattegory { get; set; }
        public virtual DbSet<PostComments> PostComments { get; set; }
        public virtual DbSet<PostLike> PostLike { get; set; }
        public virtual DbSet<PostPhotos> PostPhotos { get; set; }
        public virtual DbSet<PostVideo> PostVideo { get; set; }
        public virtual DbSet<ProfesionallsProfile> ProfesionallsProfile { get; set; }
        public virtual DbSet<ProfesionalsDocuments> ProfesionalsDocuments { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ProfileLikes> ProfileLikes { get; set; }
        public virtual DbSet<PromoPhotos> PromoPhotos { get; set; }
        public virtual DbSet<PromoVideos> PromoVideos { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Share> Share { get; set; }
        public virtual DbSet<ShareLikes> ShareLikes { get; set; }
        public virtual DbSet<StickerCattegory> StickerCattegory { get; set; }
        public virtual DbSet<Stickers> Stickers { get; set; }
        public virtual DbSet<Tutorial> Tutorial { get; set; }
        public virtual DbSet<TutorialCattegory> TutorialCattegory { get; set; }
        public virtual DbSet<TutorialClasses> TutorialClasses { get; set; }
        public virtual DbSet<TutorialPromoPhoto> TutorialPromoPhoto { get; set; }
        public virtual DbSet<TutorialPromoVideo> TutorialPromoVideo { get; set; }
        public virtual DbSet<TutorialRating> TutorialRating { get; set; }
        public virtual DbSet<TutorialSale> TutorialSale { get; set; }
        public virtual DbSet<UserCattegory> UserCattegory { get; set; }
        public virtual DbSet<UserChat> UserChat { get; set; }
        public virtual DbSet<UserSocialMediaLinks> UserSocialMediaLinks { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=studio37db;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.Property(e => e.ChatId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClassRatings>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClassVideo)
                    .WithMany(p => p.ClassRatings)
                    .HasForeignKey(d => d.ClassVideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassRatings_ClassRatings");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClassRatings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassRatings_Profile");
            });

            modelBuilder.Entity<ClassVideo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ClassVideoCattegory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Cattegory)
                    .WithMany(p => p.ClassVideoCattegory)
                    .HasForeignKey(d => d.CattegoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassVideoCattegory_Categories");

                entity.HasOne(d => d.ClassVideo)
                    .WithMany(p => p.ClassVideoCattegory)
                    .HasForeignKey(d => d.ClassVideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClassVideoCattegory_ClassVideo");
            });

            modelBuilder.Entity<ClassVideoSale>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClassVideo)
                    .WithMany(p => p.ClassVideoSale)
                    .HasForeignKey(d => d.ClassVideoId)
                    .HasConstraintName("FK_ClassVideoSale_ClassVideo");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.ClassVideoSale)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_ClassVideoSale_Sale");
            });

            modelBuilder.Entity<CommentComments>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.NewCommentNavigation)
                    .WithMany(p => p.CommentCommentsNewCommentNavigation)
                    .HasForeignKey(d => d.NewComment)
                    .HasConstraintName("FK_CommentComments_Comments");

                entity.HasOne(d => d.OldCommentNavigation)
                    .WithMany(p => p.CommentCommentsOldCommentNavigation)
                    .HasForeignKey(d => d.OldComment)
                    .HasConstraintName("FK_CommentComments_Comments1");
            });

            modelBuilder.Entity<CommentLikes>(entity =>
            {
                entity.HasKey(e => new { e.CommentId, e.LikeId })
                    .HasName("PK__CommentL__999DFD6519BD3880");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentLikes)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentLikes_Comments");

                entity.HasOne(d => d.Like)
                    .WithMany(p => p.CommentLikes)
                    .HasForeignKey(d => d.LikeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentLikes_Like");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<EventGroups>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventGroups)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_EventGroups_EventGroups");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.EventGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_EventGroups_Groups");
            });

            modelBuilder.Entity<EventUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventUsers)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_EventUsers_EventUsers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EventUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_EventUsers_Profile");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Events_Profile");
            });

            modelBuilder.Entity<Followings>(entity =>
            {
                entity.HasKey(e => new { e.Followers, e.Following })
                    .HasName("PK__Followin__A0E9ADD4CF35B012");

                entity.HasOne(d => d.FollowersNavigation)
                    .WithMany(p => p.FollowingsFollowersNavigation)
                    .HasForeignKey(d => d.Followers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Followings_Profile");

                entity.HasOne(d => d.FollowingNavigation)
                    .WithMany(p => p.FollowingsFollowingNavigation)
                    .HasForeignKey(d => d.Following)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Followings_Profile1");
            });

            modelBuilder.Entity<GoupMediaLink>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GoupMediaLink)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GoupMediaLink_Groups");
            });

            modelBuilder.Entity<GroupUser>(entity =>
            {
                entity.HasKey(e => new { e.Groupid, e.Userid })
                    .HasName("PK__GroupUse__45E89BB0BBBE8EB8");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupUser)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUser_Groups");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GroupUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUser_Profile");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK_Groups_Profile");
            });

            modelBuilder.Entity<Like>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.Property(e => e.MessageId).ValueGeneratedNever();

                entity.HasOne(d => d.Chat)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ChatId)
                    .HasConstraintName("FK_Messages_Chat");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Messages_Profile");
            });

            modelBuilder.Entity<PhotoLike>(entity =>
            {
                entity.HasKey(e => new { e.PhotoId, e.LikeId })
                    .HasName("PK__PhotoLik__0E551002423E004C");

                entity.HasOne(d => d.Like)
                    .WithMany(p => p.PhotoLike)
                    .HasForeignKey(d => d.LikeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhotoLike_Like");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PhotoLike)
                    .HasForeignKey(d => d.PhotoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhotoLike_Photos");
            });

            modelBuilder.Entity<Photos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PostCattegory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostCattegory)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostCattegory_Categories");

                entity.HasOne(d => d.PostNavigation)
                    .WithMany(p => p.PostCattegory)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostCattegory_Post");
            });

            modelBuilder.Entity<PostComments>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.PostComments)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK_PostComments_Comments");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostComments)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_PostComments_Post");
            });

            modelBuilder.Entity<PostLike>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.LikeId })
                    .HasName("PK__PostLike__F03B42D9549ABF05");

                entity.HasOne(d => d.Like)
                    .WithMany(p => p.PostLike)
                    .HasForeignKey(d => d.LikeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostLike_Like");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostLike)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostLike_Post");
            });

            modelBuilder.Entity<PostPhotos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.PostPhotos)
                    .HasForeignKey(d => d.PhotoId)
                    .HasConstraintName("FK_PostPhotos_Photos");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostPhotos)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_PostPhotos_Post");
            });

            modelBuilder.Entity<PostVideo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostVideo)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_PostVideo_Post");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.PostVideo)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_PostVideo_Videos");
            });

            modelBuilder.Entity<ProfesionallsProfile>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithOne(p => p.ProfesionallsProfile)
                    .HasForeignKey<ProfesionallsProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfesionallsProfile_Profile");
            });

            modelBuilder.Entity<ProfesionalsDocuments>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProfesionalsDocuments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProfesionalsDocuments_ProfesionalsDocuments");
            });

            modelBuilder.Entity<ProfileLikes>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LikeId })
                    .HasName("PK__ProfileL__4DA1EE8DD65EB9AD");

                entity.HasOne(d => d.Like)
                    .WithMany(p => p.ProfileLikes)
                    .HasForeignKey(d => d.LikeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfileLikes_Like");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProfileLikes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfileLikes_Profile");
            });

            modelBuilder.Entity<PromoPhotos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PromoVideos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sale_Profile");

                entity.HasOne(d => d.Profesional)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.ProfesionalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sale_ProfesionallsProfile");
            });

            modelBuilder.Entity<Share>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Share)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_Share_Post");
            });

            modelBuilder.Entity<ShareLikes>(entity =>
            {
                entity.HasKey(e => new { e.ShareId, e.LikeId })
                    .HasName("PK__ShareLik__89031D410AA6629A");

                entity.HasOne(d => d.Like)
                    .WithMany(p => p.ShareLikes)
                    .HasForeignKey(d => d.LikeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShareLikes_Like");

                entity.HasOne(d => d.Share)
                    .WithMany(p => p.ShareLikes)
                    .HasForeignKey(d => d.ShareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShareLikes_Share");
            });

            modelBuilder.Entity<StickerCattegory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.StickerCattegory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_StickerCattegory_Categories");

                entity.HasOne(d => d.Sticke)
                    .WithMany(p => p.StickerCattegory)
                    .HasForeignKey(d => d.StickeId)
                    .HasConstraintName("FK_StickerCattegory_Stickers");
            });

            modelBuilder.Entity<Stickers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Stickers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stickers_Stickers");
            });

            modelBuilder.Entity<Tutorial>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TutorialCattegory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Cattegory)
                    .WithMany(p => p.TutorialCattegory)
                    .HasForeignKey(d => d.CattegoryId)
                    .HasConstraintName("FK_TutorialCattegory_TutorialCattegory");

                entity.HasOne(d => d.Tutorial)
                    .WithMany(p => p.TutorialCattegory)
                    .HasForeignKey(d => d.TutorialId)
                    .HasConstraintName("FK_TutorialCattegory_Tutorial");
            });

            modelBuilder.Entity<TutorialClasses>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClassVideo)
                    .WithMany(p => p.TutorialClasses)
                    .HasForeignKey(d => d.ClassVideoId)
                    .HasConstraintName("FK_TutorialClasses_ClassVideo");

                entity.HasOne(d => d.Tutorial)
                    .WithMany(p => p.TutorialClasses)
                    .HasForeignKey(d => d.TutorialId)
                    .HasConstraintName("FK_TutorialClasses_TutorialCattegory");
            });

            modelBuilder.Entity<TutorialPromoPhoto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.PromoPhoto)
                    .WithMany(p => p.TutorialPromoPhoto)
                    .HasForeignKey(d => d.PromoPhotoId)
                    .HasConstraintName("FK_TutorialPromoPhoto_PromoPhotos");

                entity.HasOne(d => d.Tutorial)
                    .WithMany(p => p.TutorialPromoPhoto)
                    .HasForeignKey(d => d.TutorialId)
                    .HasConstraintName("FK_TutorialPromoPhoto_Tutorial");
            });

            modelBuilder.Entity<TutorialPromoVideo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.PromoVideo)
                    .WithMany(p => p.TutorialPromoVideo)
                    .HasForeignKey(d => d.PromoVideoId)
                    .HasConstraintName("FK_TutorialPromoVideo_PromoVideos");

                entity.HasOne(d => d.Tutorial)
                    .WithMany(p => p.TutorialPromoVideo)
                    .HasForeignKey(d => d.TutorialId)
                    .HasConstraintName("FK_TutorialPromoVideo_Tutorial");
            });

            modelBuilder.Entity<TutorialRating>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Tutorial)
                    .WithMany(p => p.TutorialRating)
                    .HasForeignKey(d => d.TutorialId)
                    .HasConstraintName("FK_TutorialRating_Tutorial");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TutorialRating)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TutorialRating_Profile");
            });

            modelBuilder.Entity<TutorialSale>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.TutorialSale)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_TutorialSale_Sale");

                entity.HasOne(d => d.Tutorial)
                    .WithMany(p => p.TutorialSale)
                    .HasForeignKey(d => d.TutorialId)
                    .HasConstraintName("FK_TutorialSale_Tutorial");
            });

            modelBuilder.Entity<UserCattegory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Cattegorry)
                    .WithMany(p => p.UserCattegory)
                    .HasForeignKey(d => d.CattegorryId)
                    .HasConstraintName("FK_UserCattegory_UserCattegory");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCattegory)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserCattegory_Profile");
            });

            modelBuilder.Entity<UserChat>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Chat)
                    .WithMany(p => p.UserChat)
                    .HasForeignKey(d => d.ChatId)
                    .HasConstraintName("FK_UserChat_Chat");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserChat)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserChat_Profile");
            });

            modelBuilder.Entity<UserSocialMediaLinks>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSocialMediaLinks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserSocialMediaLinks_Profile");
            });

            modelBuilder.Entity<Videos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
