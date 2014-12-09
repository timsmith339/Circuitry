using System.Security.Cryptography.X509Certificates;
using Circuitry.Classes;

namespace Circuitry.Interfaces
{
    public interface IComponent
    {
        event StateSwitchedHandler StateSwitched;
        ComponentState State { get; }
    }
}
