namespace RepositoryPatternBase.MySQL
{
    public class MySQLSettings : IMySQLSettings
    {
        public string ConnectionString { get; set; }
    }
    public interface IMySQLSettings
    {
        string ConnectionString { get; set; }
    }
}
