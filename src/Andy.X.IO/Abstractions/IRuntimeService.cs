using Andy.X.IO.Events;
using System.Collections.Concurrent;

namespace Andy.X.IO.Abstractions
{
    public delegate void GlobalServiceStatusChangedEventHandler(object sender, ServiceStatusChangedEventArgs e);

    internal interface IRuntimeService
    {
        public void InitializeComponents();

        public IService GetService();
        public ConcurrentDictionary<string, IService> GetServices();

        public void StartRuntime();
        public void StopRuntime();


        void StartService(string serviceId);
        void StopService(string serviceId);
        void AddService(string serviceId, IService service);
        void RemoveService(string serviceId);

        event GlobalServiceStatusChangedEventHandler ServiceStatusChanged;
    }
}
