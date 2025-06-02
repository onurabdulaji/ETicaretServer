namespace ETicaretAPI.Persistence;
public static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            //configurationManager.SetBasePath(AppContext.BaseDirectory);
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("PostgrqSql")!;
        }
    }

}

//Alternative 
//public static class Configuration
//{
//    private static readonly ConfigurationManager configurationManager;

//    static Configuration()
//    {
//        configurationManager = new ConfigurationManager();
//        configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ETicaretAPI.API"));
//        configurationManager.AddJsonFile("appsettings.json");
//    }

//    public static string ConnectionString => configurationManager.GetConnectionString("PostgreSql")!;
//}