namespace Composition
{
    public class DataMigrator
    {
        Logger logger = new Logger();

        public void Migrate()
        {
            logger.Log("Migrating...");
        }
    }
}