namespace Factorio.Interfaces
{
    public interface IProducer<TSource, TResult>
        where TSource : IProduceComponent
        where TResult : IProducible
    {
        public IEnumerable<TResult> Produce(List<TSource> sources);
    }
}
