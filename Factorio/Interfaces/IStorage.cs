namespace Factorio.Interfaces
{
    public interface IStorage<T> where T : Item
    {
        public Stack<T>[] Storage { get; set; }
        public void Collect(Stack<T> stack);
        public Stack<T> Remove();
    }
}
