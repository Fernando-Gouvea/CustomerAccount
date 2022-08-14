using MediatR;
using Newtonsoft.Json;

namespace CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer
{
    public class CustomerQueryResponse : IRequest<CustomerQueryRequest>
    {
        public IEnumerable<CustomerResponse> Customers { get; set; }
        public class CustomerResponse
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
}
