namespace Persistence.Settings
{
    public class FitnessPackageSettings : IDatabaseSettings
    {
        public FitnessPackageSettings()
        {
            CollectionName = "FitnessPackage";
            ConnectionString = AppConfig.GetConnectionString();
            DatabaseName = "BeefitMember";
        }

        public string CollectionName { get; }
        public string ConnectionString { get; }
        public string DatabaseName { get; }
    }
}