namespace Andy.X.IO.Abstractions
{
    public interface IService
    {
        bool IsServiceRunning { get; set; }
        
        string Publisher { get; }
        string Description { get; }
        string Version { get; }

        public void Start();
        public void Stop();
    }
}
