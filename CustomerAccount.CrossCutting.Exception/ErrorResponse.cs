namespace CustomerAccount.CrossCutting.Exceptions
{
    public class ErrorResponse
    {
        public ErrorResponse()
        {
            TraceId = Guid.NewGuid().ToString();
            Errors = new List<ErrorDetailsVm>();
        }

        public ErrorResponse(string logref, string message)
        {
            TraceId = Guid.NewGuid().ToString();
            Errors = new List<ErrorDetailsVm>();
            AddError(logref, message);
        }

        public string TraceId { get; private set; }
        public List<ErrorDetailsVm> Errors { get; private set; }

        public class ErrorDetailsVm
        {
            public ErrorDetailsVm(string logref, string message)
            {
                Logref = logref;
                Message = message;
            }

            public string Logref { get; private set; }

            public string Message { get; private set; }
        }

        public void AddError(string logref, string message)
        {
            Errors.Add(new ErrorDetailsVm(logref, message));
        }
    }
}
