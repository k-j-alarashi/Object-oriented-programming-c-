namespace Lab4
{
    internal class Counter
    {
        // field
        private int count;

        // property
        public int Count { get { return count; } }

        public Counter()
        {
            count = 0;
        }

        public void increment()
        {
            count++;
        }

        public void reset()
        {
            count = 0;
        }

    }
}
