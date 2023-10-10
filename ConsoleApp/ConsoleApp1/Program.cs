namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6 };


            for (int i = 0; i < array.Length/2; i++)
            {
                int arrayDigit = array[i];
                array[i] = array[array.Length - 1 - i];

                array[array.Length - 1 - i] = arrayDigit;
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}