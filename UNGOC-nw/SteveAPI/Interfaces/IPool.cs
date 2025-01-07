namespace SteveAPI.Interfaces
{
    internal interface IPool<T>
    {
        T Get();
        void Return(T obj);
    }
}
