using System.Net;

namespace CustomerAccount.CrossCutting.Exceptions
{
    public sealed class PostCustomerCommandRequestException : Exception
    {
        public PostCustomerCommandRequestException(string message) : base(message) { }


    }
}