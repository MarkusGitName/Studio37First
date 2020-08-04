
namespace Studio37Media.Shared
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    //  using System.Data.Entity.Spatial;


    public partial class Profile
    {

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
        [StringLength(13,MinimumLength =1)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Website { get; set; }

     
    }
}
