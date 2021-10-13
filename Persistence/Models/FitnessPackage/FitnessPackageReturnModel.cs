using System.Collections.Generic;

namespace Persistence.Models.FitnessPackage
{
    public class FitnessPackageReturnModel
    {
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string Logo { get; set; }
        public List<Features> Features { get; set; }
    }
}