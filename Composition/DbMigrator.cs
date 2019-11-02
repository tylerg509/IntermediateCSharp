namespace IntermediateCSharp
{
    public class DbMigrator
    {
        public readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("we are migrating");
        }
    }
}