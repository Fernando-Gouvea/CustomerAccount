using Newtonsoft.Json;

namespace CustomerAccount.CrossCutting.Configuration
{
    public class Appsettings
    {
        public static Appsettings Settings =>
            JsonConvert.DeserializeObject<Appsettings>(new StreamReader(@"appsettings.JSON").ReadToEnd());

        [JsonProperty("subscriptionKey")]
        public string SubscriptionKey { get; set; }
    }
}
