namespace Studio37API.Models.TempModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<ClassRating> ClassRatings { get; set; }
        public virtual DbSet<ClassVideo> ClassVideos { get; set; }
        public virtual DbSet<ClassVideoCattegory> ClassVideoCattegories { get; set; }
        public virtual DbSet<ClassVideoSale> ClassVideoSales { get; set; }
        public virtual DbSet<CommentComment> CommentComments { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<EventGroup> EventGroups { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventUser> EventUsers { get; set; }
        public virtual DbSet<GoupMediaLink> GoupMediaLinks { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<LiveShow> LiveShows { get; set; }
        public virtual DbSet<LiveShowCattegory> LiveShowCattegories { get; set; }
        public virtual DbSet<LiveShowComment> LiveShowComments { get; set; }
        public virtual DbSet<LiveShowView> LiveShowViews { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostCattegory> PostCattegories { get; set; }
        public virtual DbSet<PostComment> PostComments { get; set; }
        public virtual DbSet<PostPhoto> PostPhotos { get; set; }
        public virtual DbSet<PostVideo> PostVideos { get; set; }
        public virtual DbSet<ProfesionallsProfile> ProfesionallsProfiles { get; set; }
        public virtual DbSet<ProfesionalsDocument> ProfesionalsDocuments { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<PromoPhoto> PromoPhotos { get; set; }
        public virtual DbSet<PromoVideo> PromoVideos { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Share> Shares { get; set; }
        public virtual DbSet<StickerCattegory> StickerCattegories { get; set; }
        public virtual DbSet<Sticker> Stickers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tutorial> Tutorials { get; set; }
        public virtual DbSet<TutorialCattegory> TutorialCattegories { get; set; }
        public virtual DbSet<TutorialClass> TutorialClasses { get; set; }
        public virtual DbSet<TutorialPromoPhoto> TutorialPromoPhotoes { get; set; }
        public virtual DbSet<TutorialPromoVideo> TutorialPromoVideos { get; set; }
        public virtual DbSet<TutorialRating> TutorialRatings { get; set; }
        public virtual DbSet<TutorialSale> TutorialSales { get; set; }
        public virtual DbSet<UserCattegory> UserCattegories { get; set; }
        public virtual DbSet<UserChat> UserChats { get; set; }
        public virtual DbSet<UserSocialMediaLink> UserSocialMediaLinks { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.ClassVideoCattegories)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CattegoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.LiveShowCattegories)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CattegoryID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.PostCattegories)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.PostID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.TutorialCattegories)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CattegoryID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.UserCattegories)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CattegorryID);

            modelBuilder.Entity<ClassVideo>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ClassVideo>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ClassVideo>()
                .HasMany(e => e.ClassRatings)
                .WithRequired(e => e.ClassVideo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClassVideo>()
                .HasMany(e => e.ClassVideoCattegories)
                .WithRequired(e => e.ClassVideo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClassVideoSale>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Comment>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .HasMany(e => e.CommentComments)
                .WithOptional(e => e.Comment)
                .HasForeignKey(e => e.newComment);

            modelBuilder.Entity<Comment>()
                .HasMany(e => e.CommentComments1)
                .WithOptional(e => e.Comment1)
                .HasForeignKey(e => e.oldComment);

            modelBuilder.Entity<Comment>()
                .HasMany(e => e.Likes)
                .WithMany(e => e.Comments)
                .Map(m => m.ToTable("CommentLikes").MapLeftKey("CommentID").MapRightKey("LikeID"));

            modelBuilder.Entity<Event>()
                .Property(e => e.EventDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.GoupMediaLinks)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Profiles)
                .WithMany(e => e.Groups1)
                .Map(m => m.ToTable("GroupUser").MapLeftKey("Groupid").MapRightKey("Userid"));

            modelBuilder.Entity<Like>()
                .HasMany(e => e.LiveShows)
                .WithMany(e => e.Likes)
                .Map(m => m.ToTable("LiveShowLikes").MapLeftKey("LikeID").MapRightKey("LiveShowID"));

            modelBuilder.Entity<Like>()
                .HasMany(e => e.Photos)
                .WithMany(e => e.Likes)
                .Map(m => m.ToTable("PhotoLike").MapLeftKey("LikeID").MapRightKey("photoID"));

            modelBuilder.Entity<Like>()
                .HasMany(e => e.Posts)
                .WithMany(e => e.Likes)
                .Map(m => m.ToTable("PostLike").MapLeftKey("LikeId").MapRightKey("PostId"));

            modelBuilder.Entity<Like>()
                .HasMany(e => e.Profiles)
                .WithMany(e => e.Likes)
                .Map(m => m.ToTable("ProfileLikes").MapLeftKey("LikeId").MapRightKey("UserId"));

            modelBuilder.Entity<Like>()
                .HasMany(e => e.Shares)
                .WithMany(e => e.Likes)
                .Map(m => m.ToTable("ShareLikes").MapLeftKey("LikeID").MapRightKey("ShareID"));

            modelBuilder.Entity<LiveShow>()
                .Property(e => e.PriceRand)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LiveShow>()
                .HasMany(e => e.LiveShowViews)
                .WithRequired(e => e.LiveShow)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Msge)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.PostCattegories)
                .WithRequired(e => e.Post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfesionallsProfile>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ProfesionallsProfile>()
                .HasMany(e => e.LiveShows)
                .WithRequired(e => e.ProfesionallsProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfesionallsProfile>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.ProfesionallsProfile)
                .HasForeignKey(e => e.ProfesionalID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfesionallsProfile>()
                .HasMany(e => e.Stickers)
                .WithRequired(e => e.ProfesionallsProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProfesionalsDocument>()
                .Property(e => e.Discription)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.ClassRatings)
                .WithRequired(e => e.Profile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Groups)
                .WithOptional(e => e.Profile)
                .HasForeignKey(e => e.OwnerID);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.LiveShowViews)
                .WithRequired(e => e.Profile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profile>()
                .HasOptional(e => e.ProfesionallsProfile)
                .WithRequired(e => e.Profile);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Profile)
                .HasForeignKey(e => e.BuyerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Profile1)
                .WithMany(e => e.Profiles)
                .Map(m => m.ToTable("Followings").MapLeftKey("Followers").MapRightKey("Following"));

            modelBuilder.Entity<Sale>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Share>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<Sticker>()
                .HasMany(e => e.StickerCattegories)
                .WithOptional(e => e.Sticker)
                .HasForeignKey(e => e.StickeID);

            modelBuilder.Entity<Tutorial>()
                .Property(e => e.Desctription)
                .IsUnicode(false);

            modelBuilder.Entity<Tutorial>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TutorialCattegory>()
                .HasMany(e => e.TutorialClasses)
                .WithOptional(e => e.TutorialCattegory)
                .HasForeignKey(e => e.TutorialID);

            modelBuilder.Entity<TutorialSale>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
