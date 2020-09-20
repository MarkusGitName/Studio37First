namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class PaymentViewModel
    {
        public PaymentViewModel(Payment incomingPayment)
        {
            id = incomingPayment.id;
            UserID = incomingPayment.UserID;
            AmountRands = incomingPayment.AmountRands;
            AmountCredits = incomingPayment.AmountCredits;
            Date = incomingPayment.Date;
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        [Column(TypeName = "money")]
        public decimal AmountRands { get; set; }

        public int AmountCredits { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        // public virtual Profile Profile { get; set; }
    }
}
