using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Payment
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        [Column(TypeName = "money")]
        public decimal AmountRands { get; set; }

        public int AmountCredits { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

     //   public virtual Profile Profile { get; set; }
    }
}
