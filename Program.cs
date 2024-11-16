using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(DateTime.Now.Microsecond);
            Console.WriteLine("Enter the lower bound of the random number: ");
            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of the random number: ");
            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            if (lowerMaxRandomBound > upperMaxRandomBound)
            {
                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
            }
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);

            }

            Console.WriteLine("The array is: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }


            int k1 = 0, k2 = 0, k3 = 0;
            for (int i = 0; i < size; ++i)
            {
                if (arr[i] % 2 == 0)
                {
                    k1++;
                }
            }
            Console.WriteLine($"Number of even numbers : {k1}");
            Console.WriteLine();
            for (int i = 0; i < size; ++i)
            {
                if (arr[i] % 2 != 0)
                {
                    k2++;
                }
            }
            Console.WriteLine($"Number of odd numbers : {k2}");
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                int _ = 0;
                for (int j = 0; j < size; ++j)
                {
                    if (arr[j] == arr[i])
                    {
                        _++;
                    }
                }
                if (_ != 1)
                {
                    k3++;
                }
            }
            Console.WriteLine($"Number of unique numbers : {k3}");
        }
    }
}