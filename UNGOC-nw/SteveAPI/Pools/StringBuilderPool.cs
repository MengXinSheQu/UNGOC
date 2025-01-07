using System.Text;
using SteveAPI.Interfaces;

namespace SteveAPI.Pools
{
    internal class StringBuilderPool : IPool<StringBuilder>
    {
        public static StringBuilderPool Pool { get; } = new StringBuilderPool();
        public StringBuilder Get()
        {
            return NorthwoodLib.Pools.StringBuilderPool.Shared.Rent();
        }
        public void Return(StringBuilder obj)
        {
            NorthwoodLib.Pools.StringBuilderPool.Shared.Return(obj);
        }
    }
}
