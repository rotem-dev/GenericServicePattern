using Requesters.Enums;

namespace Requesters.Interfaces
{
    public interface IExternalService
    {
        public ExternalServices ServiceType { get; }
    }
}