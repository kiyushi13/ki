namespace _10Классы
{

    class FixedLengthStringArray
    {
        private string[] array;

        public FixedLengthStringArray(int length)
        {
            array = new string[length];
        }

        public void SetElement(int index, string value)
        {
            array[index] = value;
        }

        public string GetElement(int index)
        {
            return array[index];
        }

        public int FindElement(string value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }

}