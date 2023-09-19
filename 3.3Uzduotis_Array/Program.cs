using System.Linq.Expressions;

namespace _3._3Uzduotis_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] ints = { 4, 7, 9 };

            int[] result = AddElement(2, ints);

            for (int k = 0; k < result.Length; k++)
            {
                Console.WriteLine(result[k]);
            }
        }
        public static int[] AddElement(int newElement, int[] ints)
        {
            int[] newArray = new int[ints.Length + 1];

            for (int i = 0; i < ints.Length; i++)
            {
                newArray[i] = ints[i];

            }
            newArray[newArray.Length - 1] = newElement;

            return newArray;
        }
    }
}



