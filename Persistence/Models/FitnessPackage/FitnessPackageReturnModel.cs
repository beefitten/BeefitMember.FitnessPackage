using System.Collections.Generic;
using Persistence.Models.FitnessPackage.Bookings;
using Persistence.Models.FitnessPackage.CenterInformation;
using Persistence.Models.FitnessPackage.Fonts;
using Persistence.Models.FitnessPackage.More;
using Persistence.Models.FitnessPackage.Overview;
using Persistence.Models.FitnessPackage.WeightGoal;

namespace Persistence.Models.FitnessPackage
{
    public class FitnessPackageReturnModel
    {
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string ThirdColor { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderRadius { get; set; }
        public string Elevation { get; set; }
        public string Logo { get; set; }
        public List<Features> Features { get; set; }
        public OverViewModel OverView { get; set; }
        public WeightGoalModel WeightGoal { get; set; }
        public CenterInformationModel CenterInformation { get; set; }
        public MoreModel More { get; set; }
        public FontModel Font { get; set; }
        public BookingsModel Bookings { get; set; }
    }
}