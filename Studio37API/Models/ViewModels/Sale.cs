using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Sale
    {
       public Sale()
        {
            ClassVideoSales = new HashSet<ClassVideoSale>();
            LiveShowSales = new HashSet<LiveShowSale>();
            TutorialSales = new HashSet<TutorialSale>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string ProfesionalID { get; set; }

        [Required]
        [StringLength(450)]
        public string BuyerID { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public int Credits { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual ICollection<ClassVideoSale> ClassVideoSales { get; set; }

        public virtual ICollection<LiveShowSale> LiveShowSales { get; set; }

        public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

     //   public virtual Profile Profile { get; set; }

        public virtual ICollection<TutorialSale> TutorialSales { get; set; }
    }
}
