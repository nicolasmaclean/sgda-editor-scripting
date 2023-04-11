namespace SGDA.Utilities
{
    [System.Serializable]
    public class Optional<T>
    {
        public T Value;
        public bool Enabled;

        public Optional(bool enabled = false)
        {
            Enabled = enabled;
        }

        public Optional(T value, bool enabled = false) : this(enabled)
        {
            Value = value;
        }
    }
}
