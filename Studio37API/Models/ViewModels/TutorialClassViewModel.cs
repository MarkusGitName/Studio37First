namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TutorialClassViewModel
    {
        public TutorialClassViewModel(TutorialClass incomingTutorialClass)
        {
            id = incomingTutorialClass.id;
            TutorialID = incomingTutorialClass.TutorialID;
            ClassVideoID = incomingTutorialClass.ClassVideoID;
        }

        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid ClassVideoID { get; set; }

        // public virtual ClassVideo ClassVideo { get; set; }

        // public virtual TutorialCattegory TutorialCattegory { get; set; }
    }
}
