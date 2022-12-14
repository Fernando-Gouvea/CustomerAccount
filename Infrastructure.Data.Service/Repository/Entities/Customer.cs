namespace CustomerAccount.Infrastructure.Data.Service.Repository.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Old { get; set; }
        public string CivilStatus { get; set; }
        public string Document { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
