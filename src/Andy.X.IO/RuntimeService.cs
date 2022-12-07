using Andy.X.IO.Abstractions;
using System.Collections.Concurrent;

namespace Andy.X.IO
{
    public sealed class RuntimeService : IRuntimeService
    {
        public event GlobalServiceStatusChangedEventHandler ServiceStatusChanged;

        private readonly ConcurrentDictionary<string, IService> _services;

        public RuntimeService()
        {
            _services = new ConcurrentDictionary<string, IService>();
        }

        public void InitializeComponents()
        {
            throw new NotImplementedException();
        }

        public IService GetService()
        {
            throw new NotImplementedException();
        }

        public ConcurrentDictionary<string, IService> GetServices()
        {
            throw new NotImplementedException();
        }

        public void StartRuntime()
        {
            throw new NotImplementedException();
        }

        public void StopRuntime()
        {
            throw new NotImplementedException();
        }

        public void StartService(string serviceId)
        {
            throw new NotImplementedException();
        }

        public void StopService(string serviceId)
        {
            throw new NotImplementedException();
        }

        public void AddService(string serviceId, IService service)
        {
            throw new NotImplementedException();
        }

        public void RemoveService(string serviceId)
        {
            throw new NotImplementedException();
        }
    }
}
