using Factorio.Interfaces;
using Factorio.Types.Items;

namespace Factorio.Factories
{
    public class IronPlateFactory : IProductFactory
    {
        //TODO: Фабрика не должна валидировать входящие ресурсы => Нужен менеджер ресурсов
        public async Task<Stack<Item>> Produce(List<Stack<Item>> components, CancellationToken cancellationToken)
        {
            var ironOre = components.Find(x => x.GetType() == typeof(Stack<IronOre>));
            
        }
    }
}
