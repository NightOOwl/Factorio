namespace Factorio.Interfaces
{
    public abstract class Item : IDisposable
    {
        public string Name { get; }
        public string Description { get; }
        public int StackSize { get; }

        private bool _disposed = false;

        protected Item(string name, string description, int stackSize)
        {
            Name = name;
            Description = description;
            StackSize = stackSize;
        }

        public virtual void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            GC.SuppressFinalize(this);
        }

        ~Item()
        {
            Dispose();
        }
    }
}
