using Factorio.Interfaces;

namespace Factorio.Types.Items
{
    public class IronOre : Item, IProduceComponent
    {
        public IronOre(string name, string description, int stackSize) 
            : base(name, description, stackSize)
        {
        }
    }
}
