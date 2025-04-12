namespace FourthTask
{
    static class ArrayHelper
    
    {
        static int[] _myArray;
        
        public static int ArrayLength
        {
            get { return _myArray.Length; }
        }

        public static int[] MyArray
        {
            get
            {
                return _myArray;
            }
        }

        public static void SetArray(int[] array)
        {
            _myArray = array;
        }

        public static int GetByIndex(int index)
        {
            return _myArray[index];
        }

        public static void SetByIndex(int index, int element)
        {
            _myArray[index] = element;
        }

        public static void AddLastElement(int element)
        {
            int[] tempArray = new int[ArrayLength + 1];
            for (int i = 0; i < ArrayLength; i++)
            {
                tempArray[i] = _myArray[i];
            }
            tempArray[ArrayLength] = element;
            _myArray = tempArray;
        }

        public static int[] ConvertStringArrayToIntArray(string[] srtingArray)
        {
            int[] intArray = new int[srtingArray.Length];
            
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray [i] = int.Parse(srtingArray [i]);
            }

            return intArray;
        }
        
    }
}