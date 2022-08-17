using Newtonsoft.Json;

namespace CustomerAccount.CrossCutting.Configuration
{
    public class CustomSettings
    {
        public static CustomSettings Settings =>
            JsonConvert.DeserializeObject<CustomSettings>(new StreamReader(@"customsettings.JSON").ReadToEnd());
    }
}
