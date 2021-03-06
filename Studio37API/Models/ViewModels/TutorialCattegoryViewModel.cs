namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TutorialCattegoryViewModel
    {
        public TutorialCattegoryViewModel(TutorialCattegory incomingTutorialCattegory)
        {
            id = incomingTutorialCattegory.id;
            TutorialID = incomingTutorialCattegory.TutorialID;
            CattegoryID = incomingTutorialCattegory.CattegoryID;

            List<TutorialClassViewModel> newTutorialClassViewModel = new List<TutorialClassViewModel>();
            foreach (TutorialClass incomingTutorialClasses in incomingTutorialCattegory.TutorialClasses)
            {
                TutorialClasses.Add(new TutorialClassViewModel(incomingTutorialClasses));
            }
            TutorialClasses = newTutorialClassViewModel;
        }

        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid CattegoryID { get; set; }

        // public virtual Category Category { get; set; }

        // public virtual Tutorial Tutorial { get; set; }

        public virtual List<TutorialClassViewModel> TutorialClasses { get; set; }
    }
}
