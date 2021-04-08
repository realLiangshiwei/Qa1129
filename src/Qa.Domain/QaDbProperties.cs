namespace Qa
{
    public static class QaDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Qa";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Qa";
    }
}
