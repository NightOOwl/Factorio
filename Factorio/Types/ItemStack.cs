using Factorio.Interfaces;

namespace Factorio.Types
{
    public class ItemStack<T> : IDisposable where T : Item
    {
        public List<T> Items { get; private set; } = new List<T>();
        public int MaxSize { get; private set; }
        public int Count => Items.Count;

        public ItemStack(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            MaxSize = item.StackSize;
            Items.Add(item);
        }

        public List<T> Add(IEnumerable<T> items)
        {
            if (items.Any(i => i.GetType() != typeof(T)))
                throw new InvalidOperationException("All items must be of the same type.");

            var availableSlots = MaxSize - Count;
            var itemsToAdd = items.Take(availableSlots).ToList();
            Items.AddRange(itemsToAdd);

            return items.Skip(availableSlots).ToList(); // Возвращаем остаток
        }

        public List<T> Take(int amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive.");
            if (amount > Count) throw new InvalidOperationException("Not enough items in the stack.");

            var itemsToRemove = Items.Take(amount).ToList();
            Items.RemoveRange(0, amount);
            if (Count == 0)
            {
                Dispose();
            }
            return itemsToRemove;
        }

        public void Dispose()
        {
            Items.Clear();
            GC.SuppressFinalize(this);
        }
    }
}
