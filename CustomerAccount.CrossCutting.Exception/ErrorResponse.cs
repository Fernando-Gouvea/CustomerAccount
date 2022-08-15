namespace CustomerAccount.CrossCutting.Exceptions
{
    public class ErrorResponse
    {
        public ErrorResponse()
        {
            Errors = new List<ErrorDetailsVm>();
        }

        public ErrorResponse(string message)
        {
            Errors = new List<ErrorDetailsVm>();
            AddError(message);
        }

        public List<ErrorDetailsVm> Errors { get; private set; }

        public class ErrorDetailsVm
        {
            public ErrorDetailsVm(string message)
            {
                Message = message;
            }

            public string Message { get; private set; }
        }

        public void AddError(string message)
        {
            Errors.Add(new ErrorDetailsVm(message));
        }
    }
}
