namespace Andy.X.IO.Configurations
{
    internal static class ConfigLocation
    {
        public static string GetRootDirectory()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public static string ConfigDirectory()
        {
            return Path.Combine(GetRootDirectory(), "config");
        }

        public static string GetAndyXConfigurationFile()
        {
            return Path.Combine(ConfigDirectory(), "andyx_config.json");
        }
    }
}
