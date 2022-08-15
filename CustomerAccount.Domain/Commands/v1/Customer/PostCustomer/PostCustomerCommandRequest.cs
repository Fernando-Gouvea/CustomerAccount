using MediatR;
using Newtonsoft.Json;

namespace CustomerAccount.Domain.Commands.v1.Customer.PostCustomer
{
    public class PostCustomerCommandRequest : IRequest<bool>
    {
        [JsonProperty("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

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
