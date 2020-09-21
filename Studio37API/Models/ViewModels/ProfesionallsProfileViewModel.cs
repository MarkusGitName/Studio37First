namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class ProfesionallsProfileViewModel
    {
        public ProfesionallsProfileViewModel(ProfesionallsProfile incomingProfesionallsProfile)
        {
            UserID = incomingProfesionallsProfile.UserID;
            YearsExperience = incomingProfesionallsProfile.YearsExperience;
            Description = incomingProfesionallsProfile.Description;
            Logo = incomingProfesionallsProfile.Logo;
            ProfesionalEmail = incomingProfesionallsProfile.ProfesionalEmail;

            foreach (LiveShow incomingLiveShows in incomingProfesionallsProfile.LiveShows)
            {
                LiveShows.Add(new LiveShowViewModel(incomingLiveShows));
            }

            foreach (ProfesionalsDocument incomingProfesionalsDocuments in incomingProfesionallsProfile.ProfesionalsDocuments)
            {
                ProfesionalsDocuments.Add(new ProfesionalsDocumentViewModel(incomingProfesionalsDocuments));
            }

            foreach (Sale incomingSales in incomingProfesionallsProfile.Sales)
            {
                Sales.Add(new SaleViewModel(incomingSales));
            }

            foreach (Sticker incomingStickers in incomingProfesionallsProfile.Stickers)
            {
                Stickers.Add(new StickerViewModel(incomingStickers));
            }

            foreach (Tutorial incomingTutorials in incomingProfesionallsProfile.Tutorials)
            {
                Tutorials.Add(new TutorialViewModel(incomingTutorials));
            }
        }

        [Key]
        [StringLength(450)]
        public string UserID { get; set; }

        public int YearsExperience { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(450)]
        public string Logo { get; set; }

        [Required]
        [StringLength(350)]
        public string ProfesionalEmail { get; set; }

        public virtual ICollection<LiveShowViewModel> LiveShows { get; set; }

        // public virtual Profile Profile { get; set; }

        public virtual ICollection<ProfesionalsDocumentViewModel> ProfesionalsDocuments { get; set; }

        public virtual ICollection<SaleViewModel> Sales { get; set; }

        public virtual ICollection<StickerViewModel> Stickers { get; set; }

        public virtual ICollection<TutorialViewModel> Tutorials { get; set; }
    }
}
