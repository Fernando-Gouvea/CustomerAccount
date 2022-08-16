using MediatR;
using Newtonsoft.Json;

namespace CustomerAccount.Infrastructure.Data.Query.Queries.v1.Customer.GetCustomers
{
    public class GetCustomersQueryResponse
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("old")]
        public string Old { get; set; }

        [JsonProperty("civilStatus")]
        public string CivilStatus { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}
