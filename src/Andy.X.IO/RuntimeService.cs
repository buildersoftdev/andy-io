using Andy.X.IO.Abstractions;
using System.Collections.Concurrent;

namespace Andy.X.IO
{
    public sealed class RuntimeService : IRuntimeService
    {
        public event GlobalServiceStatusChangedEventHandler ServiceStatusChanged;

        private bool _isRunning;

        private readonly ConcurrentDictionary<string, IService> _services;

        public RuntimeService()
        {
            _services = new ConcurrentDictionary<string, IService>();
        }

        public void InitializeComponents()
        {
            throw new NotImplementedException();
        }

        public IService? GetService(string serviceId)
        {
            if (_services.TryGetValue(serviceId, out var service))
                return service;

            return null;
        }

        public ConcurrentDictionary<string, IService> GetServices()
        {
            return _services;
        }

        public void StartRuntime()
        {
            if (_isRunning == false)
                _isRunning = true;
        }

        public void StopRuntime()
        {
            if (_isRunning == true)
                _isRunning = false;
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
            _services.TryAdd(serviceId, service);
        }

        public void RemoveService(string serviceId)
        {
            _services.Remove(serviceId, out _);
        }
    }
}
