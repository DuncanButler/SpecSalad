namespace SpecSalad
{
    public interface TaskRole
    {
        void StoreValue(string key, object value);
        object Retrieve(string key);
    }
}