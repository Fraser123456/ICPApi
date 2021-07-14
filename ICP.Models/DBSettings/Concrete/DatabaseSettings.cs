using ICP.Models.DBSettings.Abstract;

namespace ICP.Models.DBSettings.Concrete
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
