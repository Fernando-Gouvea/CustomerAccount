using Newtonsoft.Json;

namespace CustomerAccount.CrossCutting.Configuration
{
    public class Appsettings
    {
        public static Appsettings Settings =>
            JsonConvert.DeserializeObject<Appsettings>(new StreamReader(@"appsettings.JSON").ReadToEnd());
    }
}
