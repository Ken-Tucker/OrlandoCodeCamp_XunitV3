namespace XunitDemo.Models
{
    public class TwoConstructors
    {
        public int Value { get; set; }

        public TwoConstructors()
        {
            this.Value = 42;
        }

        public TwoConstructors(int value)
        {
            Value = value;
        }
    }
}
