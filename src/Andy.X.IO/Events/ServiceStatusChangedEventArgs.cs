namespace Andy.X.IO.Events
{
    public class ServiceStatusChangedEventArgs
    {
        public string ServiceId { get; private set; }
        public int Status { get; private set; }
        public string Response { get; private set; }
        public ServiceStatusChangedEventArgs(string serviceId, int status, string response)
        {
            ServiceId = serviceId;
            Status = status;
            Response = response;
        }
    }
}
