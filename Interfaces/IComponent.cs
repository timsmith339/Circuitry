using System.Security.Cryptography.X509Certificates;
using Circuitry.Classes;

namespace Circuitry.Interfaces
{
    public interface IComponent
    {
        event Node.StateSwitchedHandler StateSwitched;
        ComponentState State { get; }
        Node HeadNode { get; }
        void SetHeadNode(Node headNode);
    }
}
