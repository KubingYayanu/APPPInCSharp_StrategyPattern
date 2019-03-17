namespace APPPInCSharp_StrategyPattern.Console.Sort
{
    public class IntSortHandler : SortHandler
    {
        private int[] array = null;

        public int Length() => array.Length;

        public bool OutOfOrder(int index) => array[index] > array[index + 1];

        public void SetArray(object array)
        {
            this.array = (int[])array;
        }

        public void Swap(int index)
        {
            int temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}