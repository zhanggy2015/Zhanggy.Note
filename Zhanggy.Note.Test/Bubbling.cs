namespace Zhanggy.Note.Test
{
    public class Bubbling
    {
        public static int[] sort(int[] inputArray)
        {
            int[] array = inputArray;
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
