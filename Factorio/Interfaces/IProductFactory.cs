namespace Factorio.Interfaces
{
    public interface IProductFactory
    {
        public Task<Stack<Item>> Produce(List<Stack<Item>> components, CancellationToken cancellationToken = default);
    }
}
